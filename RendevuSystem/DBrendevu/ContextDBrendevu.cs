namespace DBrendevu
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextDBrendevu : DbContext
    {
        public ContextDBrendevu()
            : base("name=ContextDBrendevu")
        {
        }

        public virtual DbSet<Agendamiento> Agendamiento { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendamiento>()
                .Property(e => e.Hora)
                .IsFixedLength();

            modelBuilder.Entity<Ciudades>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Ciudades>()
                .HasMany(e => e.Agendamiento)
                .WithOptional(e => e.Ciudades)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Idioma>()
                .Property(e => e.Idioma1)
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.Agendamiento)
                .WithOptional(e => e.Idioma)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Nivel>()
                .Property(e => e.Nivel1)
                .IsFixedLength();

            modelBuilder.Entity<Nivel>()
                .HasMany(e => e.Agendamiento)
                .WithOptional(e => e.Nivel)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .HasMany(e => e.Rol)
                .WithOptional(e => e.Permisos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Rol>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuarios)
                .WithMany(e => e.Rol)
                .Map(m => m.ToTable("UsuRol").MapLeftKey("Id_rol").MapRightKey("Id_Usuarios"));

            modelBuilder.Entity<Salon>()
                .Property(e => e.Nombre_Salon)
                .IsUnicode(false);

            modelBuilder.Entity<Salon>()
                .HasMany(e => e.Agendamiento)
                .WithOptional(e => e.Salon)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nombre1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nombre2)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Agendamiento)
                .WithOptional(e => e.Usuarios)
                .WillCascadeOnDelete();
        }
    }
}
