using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AxesoMovil
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAxesoService
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetUsuario/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        UsuarioInfo GetUsuario(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "ValidarUsuario", Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        UsuarioInfo ValidarUsuario(Login login);

        [OperationContract]
        [WebGet(UriTemplate = "GetClientesUsuario/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        List<ClienteOTs> GetClientesUsuario(string id);

        [OperationContract]
        [WebGet(UriTemplate = "GetOrdenesUsuarioCliente?usuario={id}&compania={cve_comp}&cliente={cve_client}",
            ResponseFormat = WebMessageFormat.Json)]
        List<OTInfo> GetOrdenesUsuarioCliente(string id, string cve_comp, string cve_client);

        [OperationContract]
        [WebGet(UriTemplate = "GetEtapasOT?compania={cve_comp}&folio={folio}",
            ResponseFormat = WebMessageFormat.Json)]
        List<EtapaInfo> GetEtapasOrden(string cve_comp, string folio);

        [OperationContract]
        [WebGet(UriTemplate = "GetSubetapas?compania={cve_comp}&folio={folio}&etapa={etapa}",
            ResponseFormat = WebMessageFormat.Json)]
        List<SubetapaInfo> GetSubetapas(string cve_comp, string folio, string etapa);

        [OperationContract]
        [WebGet(UriTemplate = "GetSubetapaHistorial?compania={cve_comp}&folio={folio}&etapa={etapa}&subetapa={subetapa}",
            ResponseFormat = WebMessageFormat.Json)]
        List<SubetapaHistorial> GetSubetapaHistorial(string cve_comp, string folio, string etapa, string subetapa);
    }
}
