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
    
    public partial class UNIDAD_DURACION
    {
        public UNIDAD_DURACION()
        {
            this.LEVANTAMIENTO_TECNICO = new HashSet<LEVANTAMIENTO_TECNICO>();
            this.LISTA_PRECIOS_MANO_OBRA = new HashSet<LISTA_PRECIOS_MANO_OBRA>();
            this.LT_MANO_OBRA = new HashSet<LT_MANO_OBRA>();
            this.MANO_OBRA_PLANEADA = new HashSet<MANO_OBRA_PLANEADA>();
            this.MANO_OBRA_REAL = new HashSet<MANO_OBRA_REAL>();
            this.PLAN_MAESTRO = new HashSet<PLAN_MAESTRO>();
            this.RECURSOS_OT = new HashSet<RECURSOS_OT>();
            this.PLAN_TRABAJO_OT_HISTORIAL = new HashSet<PLAN_TRABAJO_OT_HISTORIAL>();
            this.PLAN_TRABAJO_OT = new HashSet<PLAN_TRABAJO_OT>();
        }
    
        public int CVE_COMPANIA { get; set; }
        public int CVE_UNIDAD_DURACION { get; set; }
        public string DES_UNIDAD_DURACION { get; set; }
        public int USUARIO_REGISTRO { get; set; }
        public System.DateTime FECHAHORA_REGISTRO { get; set; }
        public int USUARIO_ULTIMA_ACTUALIZACION { get; set; }
        public System.DateTime FECHAHORA_ULTIMA_ACTUALIZACION { get; set; }
    
        public virtual ICollection<LEVANTAMIENTO_TECNICO> LEVANTAMIENTO_TECNICO { get; set; }
        public virtual ICollection<LISTA_PRECIOS_MANO_OBRA> LISTA_PRECIOS_MANO_OBRA { get; set; }
        public virtual ICollection<LT_MANO_OBRA> LT_MANO_OBRA { get; set; }
        public virtual ICollection<MANO_OBRA_PLANEADA> MANO_OBRA_PLANEADA { get; set; }
        public virtual ICollection<MANO_OBRA_REAL> MANO_OBRA_REAL { get; set; }
        public virtual ICollection<PLAN_MAESTRO> PLAN_MAESTRO { get; set; }
        public virtual ICollection<RECURSOS_OT> RECURSOS_OT { get; set; }
        public virtual ICollection<PLAN_TRABAJO_OT_HISTORIAL> PLAN_TRABAJO_OT_HISTORIAL { get; set; }
        public virtual ICollection<PLAN_TRABAJO_OT> PLAN_TRABAJO_OT { get; set; }
    }
}