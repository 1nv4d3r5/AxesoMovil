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
    
    public partial class CALENDARIO_LABORAL
    {
        public int CVE_COMPANIA { get; set; }
        public int CVE_SUCURSAL_COMPANIA { get; set; }
        public int CVE_CALENDARIO { get; set; }
        public System.DateTime FECHA { get; set; }
        public bool DIA_NOLABORAL { get; set; }
        public bool DIA_FESTIVO { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual CALENDARIO CALENDARIO { get; set; }
        public virtual COMPANIA COMPANIA { get; set; }
    }
}