﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxesoMovil
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AxesoEntities : DbContext
    {
        public AxesoEntities()
            : base("name=AxesoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACOPIO_MATERIALES> ACOPIO_MATERIALES { get; set; }
        public virtual DbSet<AM_CONDICION_COMERCIAL> AM_CONDICION_COMERCIAL { get; set; }
        public virtual DbSet<AM_MANO_OBRA> AM_MANO_OBRA { get; set; }
        public virtual DbSet<AM_MATERIALES> AM_MATERIALES { get; set; }
        public virtual DbSet<AMBIENTE_TRABAJO> AMBIENTE_TRABAJO { get; set; }
        public virtual DbSet<ANALISIS_MARGEN> ANALISIS_MARGEN { get; set; }
        public virtual DbSet<ASIGNA_PERSONAL_OT> ASIGNA_PERSONAL_OT { get; set; }
        public virtual DbSet<CALENDARIO> CALENDARIO { get; set; }
        public virtual DbSet<CALENDARIO_FESTIVO> CALENDARIO_FESTIVO { get; set; }
        public virtual DbSet<CALENDARIO_LABORAL> CALENDARIO_LABORAL { get; set; }
        public virtual DbSet<CALENDARIO_NOLABORAL> CALENDARIO_NOLABORAL { get; set; }
        public virtual DbSet<CLASIFICACION_SERVICIO> CLASIFICACION_SERVICIO { get; set; }
        public virtual DbSet<CLIENTE_UBICACION> CLIENTE_UBICACION { get; set; }
        public virtual DbSet<CLIENTE_UBICACION_DEPTO> CLIENTE_UBICACION_DEPTO { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<COMPANIA> COMPANIA { get; set; }
        public virtual DbSet<CONCEPTO_FOLIO> CONCEPTO_FOLIO { get; set; }
        public virtual DbSet<CONDICION_COMERCIAL> CONDICION_COMERCIAL { get; set; }
        public virtual DbSet<CONFIGURACION_MO_INDIRECTA> CONFIGURACION_MO_INDIRECTA { get; set; }
        public virtual DbSet<COSTO_MO> COSTO_MO { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<DEVOLUCION_MATERIALES> DEVOLUCION_MATERIALES { get; set; }
        public virtual DbSet<DISTRIBUCION_MO> DISTRIBUCION_MO { get; set; }
        public virtual DbSet<DISTRIBUCION_MO_NA> DISTRIBUCION_MO_NA { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<ENTREGA_MATERIALES> ENTREGA_MATERIALES { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<ESTATUS_OT> ESTATUS_OT { get; set; }
        public virtual DbSet<ETAPA_OT> ETAPA_OT { get; set; }
        public virtual DbSet<GPO_USUARIO> GPO_USUARIO { get; set; }
        public virtual DbSet<HERRAMIENTAS> HERRAMIENTAS { get; set; }
        public virtual DbSet<INFO_PAIS> INFO_PAIS { get; set; }
        public virtual DbSet<LEVANTAMIENTO_TECNICO> LEVANTAMIENTO_TECNICO { get; set; }
        public virtual DbSet<LINEA_NEGOCIO> LINEA_NEGOCIO { get; set; }
        public virtual DbSet<LISTA_PRECIOS> LISTA_PRECIOS { get; set; }
        public virtual DbSet<LISTA_PRECIOS_MANO_OBRA> LISTA_PRECIOS_MANO_OBRA { get; set; }
        public virtual DbSet<LISTA_PRECIOS_MATERIAL> LISTA_PRECIOS_MATERIAL { get; set; }
        public virtual DbSet<LISTA_PRECIOS_SERVICIO> LISTA_PRECIOS_SERVICIO { get; set; }
        public virtual DbSet<LT_HERRAMIENTAS_OT> LT_HERRAMIENTAS_OT { get; set; }
        public virtual DbSet<LT_MANO_OBRA> LT_MANO_OBRA { get; set; }
        public virtual DbSet<LT_MATERIALES_OT> LT_MATERIALES_OT { get; set; }
        public virtual DbSet<LT_SERVICIOS> LT_SERVICIOS { get; set; }
        public virtual DbSet<MANO_OBRA_PLANEADA> MANO_OBRA_PLANEADA { get; set; }
        public virtual DbSet<MANO_OBRA_REAL> MANO_OBRA_REAL { get; set; }
        public virtual DbSet<MARCA> MARCA { get; set; }
        public virtual DbSet<MARCA_SERVICIO> MARCA_SERVICIO { get; set; }
        public virtual DbSet<MATERIALES> MATERIALES { get; set; }
        public virtual DbSet<MUNICIPIO> MUNICIPIO { get; set; }
        public virtual DbSet<ORDEN_TRABAJO> ORDEN_TRABAJO { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<PLAN_MAESTRO> PLAN_MAESTRO { get; set; }
        public virtual DbSet<PROGRAMAS_SISTEMA> PROGRAMAS_SISTEMA { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<PUESTOS_RECURSOS> PUESTOS_RECURSOS { get; set; }
        public virtual DbSet<RECHAZO_MOTIVOS> RECHAZO_MOTIVOS { get; set; }
        public virtual DbSet<RECURSOS_OT> RECURSOS_OT { get; set; }
        public virtual DbSet<REGISTRO_ASISTENCIA> REGISTRO_ASISTENCIA { get; set; }
        public virtual DbSet<REGISTRO_CIERRE> REGISTRO_CIERRE { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }
        public virtual DbSet<SOLICITUD_MATERIALES> SOLICITUD_MATERIALES { get; set; }
        public virtual DbSet<SUBETAPA_OT> SUBETAPA_OT { get; set; }
        public virtual DbSet<SUCURSAL> SUCURSAL { get; set; }
        public virtual DbSet<TIPO_CANALIZACION> TIPO_CANALIZACION { get; set; }
        public virtual DbSet<TIPO_DISTRIBUCION> TIPO_DISTRIBUCION { get; set; }
        public virtual DbSet<TIPO_MO> TIPO_MO { get; set; }
        public virtual DbSet<TIPO_MONEDA> TIPO_MONEDA { get; set; }
        public virtual DbSet<TIPO_ORDEN> TIPO_ORDEN { get; set; }
        public virtual DbSet<TIPO_PLAFON> TIPO_PLAFON { get; set; }
        public virtual DbSet<TIPO_REGISTRO> TIPO_REGISTRO { get; set; }
        public virtual DbSet<TIPO_SERVICIO> TIPO_SERVICIO { get; set; }
        public virtual DbSet<UNIDAD_DURACION> UNIDAD_DURACION { get; set; }
        public virtual DbSet<UNIDAD_MEDIDA> UNIDAD_MEDIDA { get; set; }
        public virtual DbSet<UNIDAD_SERVICIO> UNIDAD_SERVICIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<USUARIO_SUCURSAL> USUARIO_SUCURSAL { get; set; }
        public virtual DbSet<ACCESO> ACCESO { get; set; }
        public virtual DbSet<AM_SERVICIOS> AM_SERVICIOS { get; set; }
        public virtual DbSet<ARCHIVOS_ADJUNTOS> ARCHIVOS_ADJUNTOS { get; set; }
        public virtual DbSet<CONSULTA_PREFERENCIAS> CONSULTA_PREFERENCIAS { get; set; }
        public virtual DbSet<LOCALIDAD> LOCALIDAD { get; set; }
        public virtual DbSet<LoginCorrecto> LoginCorrecto { get; set; }
        public virtual DbSet<PLAN_TRABAJO_OT> PLAN_TRABAJO_OT { get; set; }
        public virtual DbSet<PLAN_TRABAJO_OT_HISTORIAL> PLAN_TRABAJO_OT_HISTORIAL { get; set; }
        public virtual DbSet<TRANSACCION> TRANSACCION { get; set; }
    }
}