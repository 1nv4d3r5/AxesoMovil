using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AxesoMovil
{
    [DataContract]
    public class ClienteOTs
    {
        // Apegandose al esquema del Entity Framework, utilizamos el mismo nombre que la BD para representar atributos de sus tablas.
        [DataMember]
        public int CVE_CLIENTE { get; set; }
        
        [DataMember]
        public string NOMBRE_CLIENTE { get; set; }

        // Nos da el resultado de la cantidad de ordenes de trabajo asociadas con este cliente.
        [DataMember]
        public int CANTIDAD_OT { get; set; }
    }
}