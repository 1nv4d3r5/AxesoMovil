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
    
    public partial class LISTA_PRECIOS_SERVICIO
    {
        public int CVE_COMPANIA { get; set; }
        public int CVE_LISTA_PRECIOS { get; set; }
        public int CVE_SERVICIO { get; set; }
        public int CVE_UNIDAD_SERVICIO { get; set; }
        public Nullable<decimal> COSTO_REAL_SERVICIO { get; set; }
        public Nullable<decimal> COSTO_ESTANDAR_SERVICIO { get; set; }
        public decimal PRECIO_VENTA_SERVICIO { get; set; }
        public int CVE_TIPO_MONEDA { get; set; }
        public Nullable<decimal> POR_MARGEN_GANA { get; set; }
        public string OBSERVACIONES { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual SERVICIOS SERVICIOS { get; set; }
        public virtual TIPO_MONEDA TIPO_MONEDA { get; set; }
        public virtual UNIDAD_SERVICIO UNIDAD_SERVICIO { get; set; }
    }
}