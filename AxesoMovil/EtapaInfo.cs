using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AxesoMovil
{
    [DataContract]
    public class EtapaInfo
    {
        [DataMember]
        public int CVE_ETAPA_OT { get; set; }

        [DataMember]
        public string DES_ETAPA_OT { get; set; }

        [DataMember]
        public DateTime? FECHA_INICIO_ESTIMADA { get; set; }

        [DataMember]
        public DateTime? FECHA_FINAL_ESTIMADA { get; set; }

        [DataMember]
        public DateTime? FECHA_INICIO_REAL { get; set; }

        [DataMember]
        public DateTime? FECHA_FINAL_REAL { get; set; }

        [DataMember]
        public int AVANCE { get; set; }
    }
}