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
    
    public partial class CALENDARIO
    {
        public CALENDARIO()
        {
            this.CALENDARIO_FESTIVO = new HashSet<CALENDARIO_FESTIVO>();
            this.CALENDARIO_LABORAL = new HashSet<CALENDARIO_LABORAL>();
            this.CALENDARIO_NOLABORAL = new HashSet<CALENDARIO_NOLABORAL>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int CVE_SUCURSAL { get; set; }
        public int CVE_CALENDARIO { get; set; }
        public string DES_CALENDARIO { get; set; }
        public string OBSERVACIONES { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual COMPANIA COMPANIA { get; set; }
        public virtual ICollection<CALENDARIO_FESTIVO> CALENDARIO_FESTIVO { get; set; }
        public virtual ICollection<CALENDARIO_LABORAL> CALENDARIO_LABORAL { get; set; }
        public virtual ICollection<CALENDARIO_NOLABORAL> CALENDARIO_NOLABORAL { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
