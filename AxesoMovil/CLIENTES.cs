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
    
    public partial class CLIENTES
    {
        public CLIENTES()
        {
            this.CLIENTE_UBICACION_DEPTO = new HashSet<CLIENTE_UBICACION_DEPTO>();
            this.ORDEN_TRABAJO = new HashSet<ORDEN_TRABAJO>();
            this.CLIENTE_UBICACION_DEPTO1 = new HashSet<CLIENTE_UBICACION_DEPTO>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int CVE_CLIENTE { get; set; }
        public int CVE_SUCURSAL_COMPANIA { get; set; }
        public string RFC_CLIENTE { get; set; }
        public string RAZON_SOCIAL_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string CALLE_CLIENTE { get; set; }
        public string NUM_EXTERIOR_CLIENTE { get; set; }
        public string INTERIOR_CLIENTE { get; set; }
        public string COLONIA_CLIENTE { get; set; }
        public int CP_CLIENTE { get; set; }
        public int CVE_PAIS { get; set; }
        public int CVE_ESTADO { get; set; }
        public int CVE_MUNICIPIO { get; set; }
        public int CVE_EMPRESA { get; set; }
        public string NOMBRE_CONTACTO { get; set; }
        public string CONTACTO_TELEFONO1 { get; set; }
        public string CONTACTO_TELEFONO2 { get; set; }
        public string CONTACTO_EXTENSION1 { get; set; }
        public string CONTACTO_EXTENSION2 { get; set; }
        public string CONTACTO_CELULAR { get; set; }
        public string CONTACTO_EMAIL { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
        public int CVE_LISTA_PRECIOS { get; set; }
    
        public virtual ICollection<CLIENTE_UBICACION_DEPTO> CLIENTE_UBICACION_DEPTO { get; set; }
        public virtual COMPANIA COMPANIA { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual PAIS PAIS { get; set; }
        public virtual ICollection<ORDEN_TRABAJO> ORDEN_TRABAJO { get; set; }
        public virtual ICollection<CLIENTE_UBICACION_DEPTO> CLIENTE_UBICACION_DEPTO1 { get; set; }
    }
}
