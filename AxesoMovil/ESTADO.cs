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
    
    public partial class ESTADO
    {
        public ESTADO()
        {
            this.MUNICIPIO = new HashSet<MUNICIPIO>();
        }
    
        public int CVE_PAIS { get; set; }
        public int CVE_ESTADO { get; set; }
        public string NOMBRE_ESTADO { get; set; }
    
        public virtual PAIS PAIS { get; set; }
        public virtual ICollection<MUNICIPIO> MUNICIPIO { get; set; }
    }
}