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
    
    public partial class TIPO_ORDEN
    {
        public TIPO_ORDEN()
        {
            this.ORDEN_TRABAJO = new HashSet<ORDEN_TRABAJO>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int CVE_TIPO_OT { get; set; }
        public string DES_TIPO_OT { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ICollection<ORDEN_TRABAJO> ORDEN_TRABAJO { get; set; }
    }
}