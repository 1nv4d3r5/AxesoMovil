using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AxesoMovil
{
    [DataContract]
    public class OTInfo
    {
        [DataMember]
        public int FOLIO_OT { get; set; }

        [DataMember]
        public string NOMBRE_SERVICIO { get; set; }

        [DataMember]
        public string NOMBRE_SUCURSAL_COMPANIA { get; set; }

        [DataMember]
        public int CVE_ESTATUS_OT { get; set; }

        [DataMember]
        public string DES_ESTATUS_OT { get; set; }

        [DataMember]
        public int AVANCE { get; set; }
    }
}