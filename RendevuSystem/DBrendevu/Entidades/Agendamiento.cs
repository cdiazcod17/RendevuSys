namespace DBrendevu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agendamiento")]
    public partial class Agendamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Agendamiento { get; set; }

        public int? Id_Usuarios { get; set; }

        public int? Id_Salon { get; set; }

        public int? Id_Nivel { get; set; }

        public int? Id_idioma { get; set; }

        public int? Id_Ciudad { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Hora { get; set; }

        public virtual Ciudades Ciudades { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual Nivel Nivel { get; set; }

        public virtual Salon Salon { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
