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
    
    public partial class MATERIALES
    {
        public MATERIALES()
        {
            this.AM_MATERIALES = new HashSet<AM_MATERIALES>();
            this.DEVOLUCION_MATERIALES = new HashSet<DEVOLUCION_MATERIALES>();
            this.ENTREGA_MATERIALES = new HashSet<ENTREGA_MATERIALES>();
            this.LISTA_PRECIOS_MATERIAL = new HashSet<LISTA_PRECIOS_MATERIAL>();
            this.LT_MATERIALES_OT = new HashSet<LT_MATERIALES_OT>();
            this.SOLICITUD_MATERIALES = new HashSet<SOLICITUD_MATERIALES>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public string NUM_PARTE_MATERIAL { get; set; }
        public string DES_MATERIAL { get; set; }
        public string CVE_UNIDAD_MEDIDA_MAYOR { get; set; }
        public int CANTIDAD_MEDIDA { get; set; }
        public string CVE_UNIDAD_MEDIDA_MENOR { get; set; }
        public int CVE_MARCA { get; set; }
        public int CVE_PROVEEDOR { get; set; }
        public string NUM_PARTE_PROVEEDOR { get; set; }
        public bool ACTIVO_MATERIAL { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ICollection<AM_MATERIALES> AM_MATERIALES { get; set; }
        public virtual ICollection<DEVOLUCION_MATERIALES> DEVOLUCION_MATERIALES { get; set; }
        public virtual ICollection<ENTREGA_MATERIALES> ENTREGA_MATERIALES { get; set; }
        public virtual ICollection<LISTA_PRECIOS_MATERIAL> LISTA_PRECIOS_MATERIAL { get; set; }
        public virtual ICollection<LT_MATERIALES_OT> LT_MATERIALES_OT { get; set; }
        public virtual MARCA MARCA { get; set; }
        public virtual ICollection<SOLICITUD_MATERIALES> SOLICITUD_MATERIALES { get; set; }
    }
}
