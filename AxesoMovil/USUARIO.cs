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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.EMPRESA = new HashSet<EMPRESA>();
            this.USUARIO_SUCURSAL = new HashSet<USUARIO_SUCURSAL>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int ID_USUARIO { get; set; }
        public int CVE_SUCURSAL_COMPANIA { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string PASSWORD { get; set; }
        public int CVE_GPO_USUARIO { get; set; }
        public string CUENTA_USUARIO { get; set; }
        public bool USUARIO_ACTIVO { get; set; }
        public Nullable<int> USUARIO_REGISTRO { get; set; }
        public Nullable<System.DateTime> FECHAHORA_REGISTRO { get; set; }
        public Nullable<int> USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public Nullable<System.DateTime> FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual COMPANIA COMPANIA { get; set; }
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
        public virtual GPO_USUARIO GPO_USUARIO { get; set; }
        public virtual ICollection<USUARIO_SUCURSAL> USUARIO_SUCURSAL { get; set; }
    }
}
