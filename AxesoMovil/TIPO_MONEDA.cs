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
    
    public partial class TIPO_MONEDA
    {
        public TIPO_MONEDA()
        {
            this.ANALISIS_MARGEN = new HashSet<ANALISIS_MARGEN>();
            this.EMPLEADOS = new HashSet<EMPLEADOS>();
            this.LISTA_PRECIOS_MANO_OBRA = new HashSet<LISTA_PRECIOS_MANO_OBRA>();
            this.LISTA_PRECIOS_MATERIAL = new HashSet<LISTA_PRECIOS_MATERIAL>();
            this.LISTA_PRECIOS_SERVICIO = new HashSet<LISTA_PRECIOS_SERVICIO>();
        }
    
        public int CVE_TIPO_MONEDA { get; set; }
        public string DES_TIPO_MONEDA { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_USUARIO_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ICollection<ANALISIS_MARGEN> ANALISIS_MARGEN { get; set; }
        public virtual ICollection<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual ICollection<LISTA_PRECIOS_MANO_OBRA> LISTA_PRECIOS_MANO_OBRA { get; set; }
        public virtual ICollection<LISTA_PRECIOS_MATERIAL> LISTA_PRECIOS_MATERIAL { get; set; }
        public virtual ICollection<LISTA_PRECIOS_SERVICIO> LISTA_PRECIOS_SERVICIO { get; set; }
    }
}
