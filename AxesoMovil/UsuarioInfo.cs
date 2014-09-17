using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AxesoMovil
{
    [DataContract]
    public class UsuarioInfo
    {
        [DataMember]
        public int ID_USUARIO { get; set; }

        [DataMember]
        public int CVE_COMPANIA { get; set; }

        [DataMember]
        public string NOMBRE_USUARIO { get; set; }

        [DataMember]
        public string NOMBRE_COMPANIA { get; set; }

        [DataMember]
        public List<Transaccion> TRANSACCIONES { get; set; }

        public UsuarioInfo()
        {
            ID_USUARIO = 0;
            CVE_COMPANIA = 0;
            NOMBRE_USUARIO = "n.d.";
            NOMBRE_COMPANIA = "n.d.";
            TRANSACCIONES = new List<Transaccion>();
        }
    }

    [DataContract]
    public class Transaccion
    {
        [DataMember]
        public int CVE_TRANSACCION { get; set; }
    }

    [DataContract]
    public class Login
    {
        [DataMember]
        public string cuenta { get; set; }

        [DataMember]
        public string password { get; set; }
    }
}