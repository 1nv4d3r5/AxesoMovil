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
    
    public partial class PAIS
    {
        public PAIS()
        {
            this.CLIENTES = new HashSet<CLIENTES>();
            this.COMPANIA = new HashSet<COMPANIA>();
            this.ESTADO = new HashSet<ESTADO>();
            this.LOCALIDAD = new HashSet<LOCALIDAD>();
            this.SUCURSAL = new HashSet<SUCURSAL>();
        }
    
        public int CVE_PAIS { get; set; }
        public string NOMBRE_PAIS { get; set; }
    
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
        public virtual ICollection<COMPANIA> COMPANIA { get; set; }
        public virtual ICollection<ESTADO> ESTADO { get; set; }
        public virtual ICollection<LOCALIDAD> LOCALIDAD { get; set; }
        public virtual ICollection<SUCURSAL> SUCURSAL { get; set; }
    }
}
