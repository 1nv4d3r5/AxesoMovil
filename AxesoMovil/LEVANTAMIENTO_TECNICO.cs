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
    
    public partial class LEVANTAMIENTO_TECNICO
    {
        public LEVANTAMIENTO_TECNICO()
        {
            this.AM_MATERIALES = new HashSet<AM_MATERIALES>();
            this.DEVOLUCION_MATERIALES = new HashSet<DEVOLUCION_MATERIALES>();
            this.ENTREGA_MATERIALES = new HashSet<ENTREGA_MATERIALES>();
            this.LT_MATERIALES_OT = new HashSet<LT_MATERIALES_OT>();
            this.SOLICITUD_MATERIALES = new HashSet<SOLICITUD_MATERIALES>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int FOLIO_OT { get; set; }
        public int FOLIO_AREA_TRABAJO { get; set; }
        public string NOM_AREA_TRABAJO { get; set; }
        public int CVE_AMBIENTE_TRABAJO { get; set; }
        public decimal ALTURA_TRABAJO { get; set; }
        public decimal DURACION_EJECUCION { get; set; }
        public int CVE_UNIDAD_DURACION { get; set; }
        public string HORARIO_TRABAJO { get; set; }
        public string OBSERVACIONES { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ICollection<AM_MATERIALES> AM_MATERIALES { get; set; }
        public virtual AMBIENTE_TRABAJO AMBIENTE_TRABAJO { get; set; }
        public virtual ICollection<DEVOLUCION_MATERIALES> DEVOLUCION_MATERIALES { get; set; }
        public virtual ICollection<ENTREGA_MATERIALES> ENTREGA_MATERIALES { get; set; }
        public virtual ORDEN_TRABAJO ORDEN_TRABAJO { get; set; }
        public virtual UNIDAD_DURACION UNIDAD_DURACION { get; set; }
        public virtual ICollection<LT_MATERIALES_OT> LT_MATERIALES_OT { get; set; }
        public virtual ICollection<SOLICITUD_MATERIALES> SOLICITUD_MATERIALES { get; set; }
    }
}