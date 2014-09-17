using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AxesoMovil
{
    [DataContract]
    public class SubetapaHistorial
    {
        [DataMember]
        public int AVANCE { get; set; }

        [DataMember]
        public DateTime FECHAHORA_ACTUALIZACION { get; set; }

        [DataMember]
        public string USUARIO_ACTUALIZACION_NOMBRE { get; set; }

        [DataMember]
        public string COMENTARIOS { get; set; }
    }
}