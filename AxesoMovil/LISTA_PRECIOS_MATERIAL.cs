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
    
    public partial class LISTA_PRECIOS_MATERIAL
    {
        public int CVE_COMPANIA { get; set; }
        public int CVE_LISTA_PRECIOS { get; set; }
        public string NUM_PARTE_MATERIAL { get; set; }
        public Nullable<decimal> COSTO_REAL { get; set; }
        public Nullable<decimal> COSTO_ESTANDAR { get; set; }
        public Nullable<decimal> POR_MARGEN_GANANCIA { get; set; }
        public decimal PRECIO_VENTA_UM_MAYOR { get; set; }
        public int CVE_TIPO_MONEDA { get; set; }
        public decimal PRECIO_VENTA_UM_MENOR { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual MATERIALES MATERIALES { get; set; }
        public virtual TIPO_MONEDA TIPO_MONEDA { get; set; }
    }
}
