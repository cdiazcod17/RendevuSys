namespace DBrendevu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Agendamiento = new HashSet<Agendamiento>();
            Rol = new HashSet<Rol>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Usuarios { get; set; }

        public int? Id_Agendamiento { get; set; }

        [StringLength(20)]
        public string Nombre1 { get; set; }

        [StringLength(20)]
        public string Nombre2 { get; set; }

        [StringLength(20)]
        public string Apellido1 { get; set; }

        [StringLength(20)]
        public string Apellido2 { get; set; }

        [StringLength(20)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string CorreoElectronico { get; set; }

        [Required]
        [StringLength(11)]
        public string Clave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agendamiento> Agendamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rol> Rol { get; set; }
    }
}
