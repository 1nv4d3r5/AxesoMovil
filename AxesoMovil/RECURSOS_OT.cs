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
    
    public partial class RECURSOS_OT
    {
        public int CVE_COMPANIA { get; set; }
        public int FOLIO_OT { get; set; }
        public int CVE_LEVANTA_TECNICO { get; set; }
        public int CVE_RECURSO_REQUERIDO { get; set; }
        public int CANTIDAD_RECURSOS_REQUERIDOS { get; set; }
        public decimal DURACION { get; set; }
        public int CVE_UNIDAD_DURACION { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ORDEN_TRABAJO ORDEN_TRABAJO { get; set; }
        public virtual UNIDAD_DURACION UNIDAD_DURACION { get; set; }
    }
}
