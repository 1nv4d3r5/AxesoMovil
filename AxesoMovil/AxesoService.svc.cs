using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AxesoMovil
{
    public class AxesoService : IAxesoService
    {
        // Constante para indicar la clave asociada al programa de la aplicacion movil en las tablas ACCESO y TRANSACCIONs
        private const int CVE_PROGRAMA_MOVIL = 1002500;
        public UsuarioInfo GetUsuario(string id)
        {
            int id_usuario = Int32.Parse(id);
            return GetUsuario(id_usuario);
        }

        private UsuarioInfo GetUsuario(int id_usuario)
        {
            using (AxesoEntities db = new AxesoEntities())
            {
                var usuarioInfoQuery = from usuario in db.USUARIO
                                       join compania in db.COMPANIA on usuario.CVE_COMPANIA equals compania.CVE_COMPANIA
                                       where usuario.ID_USUARIO == id_usuario
                                       select new UsuarioInfo
                                       {
                                           ID_USUARIO = usuario.ID_USUARIO,
                                           CVE_COMPANIA = compania.CVE_COMPANIA,
                                           NOMBRE_USUARIO = usuario.NOMBRE_USUARIO,
                                           NOMBRE_COMPANIA = compania.NOMBRE_COMPANIA,
                                           TRANSACCIONES = (from acceso in db.ACCESO
                                                            where acceso.CVE_COMPANIA == usuario.CVE_COMPANIA && acceso.CVE_GPO_USUARIO == usuario.CVE_GPO_USUARIO && acceso.CVE_PROGRAMA == CVE_PROGRAMA_MOVIL
                                                            select new Transaccion { CVE_TRANSACCION = acceso.CVE_TRANSACCION - acceso.CVE_PROGRAMA ?? 0 }).ToList()
                                       };
                // Un for es la manera mas simple de verificar que la lista de resultados de tipo IQueryable este vacia o no.
                foreach (UsuarioInfo ui in usuarioInfoQuery)
                {
                    return ui; // Regresa siempre el primer resultado.
                }
                return new UsuarioInfo();
            }
        }

        public UsuarioInfo ValidarUsuario(Login login)
        {
            using (AxesoEntities db = new AxesoEntities())
            {
                var query = from usuario in db.USUARIO
                            where usuario.CUENTA_USUARIO == login.cuenta && usuario.PASSWORD == login.password
                            select usuario.ID_USUARIO;
                // Un for es la manera mas simple de verificar que la lista de resultados de tipo IQueryable este vacia o no.
                // Esta misma forma de validacion se usara para todas las operaciones que deban regresar una unica tupla o un unico campo/valor.
                foreach (int id in query)
                {
                    // Se regresa siempre el primer resultado.
                    return GetUsuario(id);
                }
                return null;
            }
        }

        public List<ClienteOTs> GetClientesUsuario(string id, string cve_comp)
        {
            int id_usuario = Int32.Parse(id);
            int cve_compania = Int32.Parse(cve_comp);
            using (AxesoEntities db = new AxesoEntities())
            {
                var clienteots = from cliente in db.CLIENTES
                                 select new ClienteOTs
                                 {
                                     CVE_CLIENTE = cliente.CVE_CLIENTE,
                                     NOMBRE_CLIENTE = cliente.NOMBRE_CLIENTE,
                                     CANTIDAD_OT = (from ot in db.ORDEN_TRABAJO
                                                    // TODO: Validar el estatus de las OTs. (i.e. que no esten rechazadas, perdidas, etc.)
                                                    where ot.USUARIO_RESPONSABLE_OT == id_usuario && ot.CVE_CLIENTE == cliente.CVE_CLIENTE && ot.CVE_COMPANIA == cliente.CVE_COMPANIA && ot.CVE_COMPANIA == cve_compania
                                                    group ot by ot.CVE_CLIENTE into otscliente
                                                    select otscliente.Count()).FirstOrDefault()
                                 };
                return clienteots.Where(cliente => cliente.CANTIDAD_OT > 0).ToList();
            }
        }

        public List<OTInfo> GetOrdenesUsuarioCliente(string id, string cve_comp, string cve_client)
        {
            int id_usuario = Int32.Parse(id);
            int cve_compania = Int32.Parse(cve_comp);
            int cve_cliente = Int32.Parse(cve_client);
            using (AxesoEntities db = new AxesoEntities())
            {
                var ordenes = from ot in db.ORDEN_TRABAJO
                              from estatus in db.ESTATUS_OT
                              where ot.CVE_COMPANIA == cve_compania && ot.CVE_CLIENTE == cve_cliente && ot.USUARIO_RESPONSABLE_OT == id_usuario && estatus.CVE_COMPANIA == cve_compania && estatus.CVE_ESTATUS_OT == ot.CVE_ESTATUS_OT
                              select new OTInfo
                              {
                                  FOLIO_OT = ot.FOLIO_OT,
                                  NOMBRE_SERVICIO = ot.NOMBRE_SERVICIO,
                                  NOMBRE_SUCURSAL_COMPANIA = (from sucursal in db.SUCURSAL
                                                                  where sucursal.CVE_COMPANIA == cve_compania && sucursal.CVE_SUCURSAL_COMPANIA == ot.CVE_SUCURSAL_COMPANIA
                                                                  select sucursal.NOMBRE_SUCURSAL_COMPANIA).FirstOrDefault(),
                                  CVE_ESTATUS_OT = estatus.CVE_ESTATUS_OT,
                                  DES_ESTATUS_OT = estatus.DES_ESTATUS_OT,
                                  // Se calcula el avance global de la OT con un promedio de los porcentajes de avance, agrupados por etapa.
                                  AVANCE = (int)(from plan in db.PLAN_TRABAJO_OT
                                                 where plan.FOLIO_OT == ot.FOLIO_OT && plan.CVE_COMPANIA == ot.CVE_COMPANIA
                                                 // Importante validar que los valores NULL se consideren como 0.
                                                 group plan.PORCENTAJE_AVANCE ?? 0 by plan.CVE_ETAPA_OT into planEtapa
                                                 select planEtapa.Average()).Average()
                              };
                return ordenes.ToList();
            }
        }

        public List<EtapaInfo> GetEtapasOrden(string cve_comp, string folio)
        {
            int cve_compania = Int32.Parse(cve_comp);
            int folio_ot = Int32.Parse(folio);
            using (AxesoEntities db = new AxesoEntities())
            {
                var etapas = from plan in db.PLAN_TRABAJO_OT
                             where plan.CVE_COMPANIA == cve_compania && plan.FOLIO_OT == folio_ot
                             group plan by plan.CVE_ETAPA_OT into etapasPlan
                             select new EtapaInfo
                             {
                                 CVE_ETAPA_OT = etapasPlan.Key,
                                 DES_ETAPA_OT = (from e in db.ETAPA_OT
                                                 where e.CVE_ETAPA_OT == etapasPlan.Key && e.CVE_COMPANIA == cve_compania
                                                 select e.DES_ETAPA_OT).FirstOrDefault(),
                                 FECHA_INICIO_ESTIMADA = etapasPlan.Min(ep => ep.FECHA_INICIO_ESTIMADA),
                                 FECHA_FINAL_ESTIMADA = etapasPlan.Max(ep => ep.FECHA_FINAL_ESTIMADA),
                                 FECHA_INICIO_REAL = etapasPlan.Min(ep => ep.FECHA_INICIO_REAL),
                                 // Para la fecha final de la etapa, obtiene de todas las tuplas de sus subetapas la que tenga el mayor valor en FECHA_FINAL_REAL, o si alguna tiene un valor de NULL en este campo, asigna el valor de NULL.
                                 FECHA_FINAL_REAL = (from ep in etapasPlan
                                                         // Se ordenan las tuplas de subetapas de manera que primero aparezcan las que tienen valor de NULL en FECHA_FINAL_REAL, luego en orden de mayor a menor las que si tienen un valor de fecha.
                                                         orderby ep.FECHA_FINAL_REAL == null descending, ep.FECHA_FINAL_REAL descending
                                                         select ep.FECHA_FINAL_REAL).FirstOrDefault(),
                                 AVANCE = (int) etapasPlan.Select(ep => ep.PORCENTAJE_AVANCE ?? 0).Average()
                             };
                return etapas.ToList();
            }
        }

        public List<SubetapaInfo> GetSubetapas(string cve_comp, string folio, string etapa)
        {
            int cve_compania = Int32.Parse(cve_comp);
            int folio_ot = Int32.Parse(folio);
            int cve_etapa_ot = Int32.Parse(etapa);
            using (AxesoEntities db = new AxesoEntities())
            {
                var subetapas = from plan in db.PLAN_TRABAJO_OT
                                where plan.CVE_COMPANIA == cve_compania && plan.FOLIO_OT == folio_ot && plan.CVE_ETAPA_OT == cve_etapa_ot
                                select new SubetapaInfo
                                {
                                    CVE_SUBETAPA_OT = plan.CVE_SUBETAPA_OT,
                                    DES_SUBETAPA_OT = (from subetapa in db.SUBETAPA_OT
                                                       where subetapa.CVE_COMPANIA == cve_compania && subetapa.CVE_ETAPA_OT == cve_etapa_ot && subetapa.CVE_SUBETAPA_OT == plan.CVE_SUBETAPA_OT
                                                       select subetapa.DES_SUBETAPA_OT).FirstOrDefault(),
                                    FECHA_INICIO_ESTIMADA = plan.FECHA_INICIO_ESTIMADA,
                                    FECHA_FINAL_ESTIMADA = plan.FECHA_FINAL_ESTIMADA,
                                    FECHA_INICIO_REAL = plan.FECHA_INICIO_REAL,
                                    FECHA_FINAL_REAL = plan.FECHA_FINAL_REAL,
                                    AVANCE = plan.PORCENTAJE_AVANCE ?? 0
                                };
                return subetapas.ToList();
            }
        }

        public List<SubetapaHistorial> GetSubetapaHistorial(string cve_comp, string folio, string etapa, string subetapa)
        {
            int cve_compania = Int32.Parse(cve_comp);
            int folio_ot = Int32.Parse(folio);
            int cve_etapa_ot = Int32.Parse(etapa);
            int cve_subetapa_ot = Int32.Parse(subetapa);
            using (AxesoEntities db = new AxesoEntities())
            {
                var historial = from planHistorial in db.PLAN_TRABAJO_OT_HISTORIAL
                                where planHistorial.CVE_COMPANIA == cve_compania && planHistorial.FOLIO_OT == folio_ot && planHistorial.CVE_ETAPA_OT == cve_etapa_ot && planHistorial.CVE_SUBETAPA_OT == cve_subetapa_ot
                                select new SubetapaHistorial
                                {
                                    AVANCE = planHistorial.PORCENTAJE_AVANCE ?? 0,
                                    FECHAHORA_ACTUALIZACION = planHistorial.FECHAHORA_ACTUALIZACION,
                                    USUARIO_ACTUALIZACION_NOMBRE = (from usuario in db.USUARIO
                                                                    where usuario.CVE_COMPANIA == cve_compania && usuario.ID_USUARIO == planHistorial.USUARIO_ACTUALIZACION
                                                                    select usuario.NOMBRE_USUARIO).FirstOrDefault(),
                                    COMENTARIOS = planHistorial.COMENTARIOS
                                };
                return historial.OrderBy(h => h.FECHAHORA_ACTUALIZACION).ToList();
            }
        }
    }
}
