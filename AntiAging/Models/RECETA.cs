//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntiAging.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RECETA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECETA()
        {
            this.DETALLE_RECETA = new HashSet<DETALLE_RECETA>();
        }
    
        public int ID_RECETA { get; set; }
        public System.DateTime FECHA { get; set; }
        public int ID_PACIENTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_RECETA> DETALLE_RECETA { get; set; }
        public virtual PACIENTE PACIENTE { get; set; }
    }
}
