using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AxesoMovil
{
    [DataContract]
    public class ReporteBitacora
    {
        [DataMember]
        public int ID_USUARIO { get; set; }

        [DataMember]
        public int CVE_COMPANIA { get; set; }

        [DataMember]
        public int FOLIO_OT { get; set; }

        [DataMember]
        public int CVE_ETAPA_OT { get; set; }

        [DataMember]
        public int CVE_SUBETAPA_OT { get; set; }

        [DataMember]
        public int AVANCE { get; set; }

        [DataMember]
        public string COMENTARIOS { get; set; }
    }
}
