//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estudiantes.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estudiante()
        {
            this.notas = new HashSet<notas>();
        }
    
        public int idEstudiante { get; set; }
        public string nombresEstudiante { get; set; }
        public string apellidos { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notas> notas { get; set; }
    }
}
