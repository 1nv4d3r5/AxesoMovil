//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CLASIFICACION_SERVICIO
    {
        public CLASIFICACION_SERVICIO()
        {
            this.SERVICIOS = new HashSet<SERVICIOS>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int CVE_CLAS_SERVICIO { get; set; }
        public string DES_CLAS_SERVICIO { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ICollection<SERVICIOS> SERVICIOS { get; set; }
    }
}
