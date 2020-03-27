using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        private int UsuarioId { get; set; } 
        public string Cedula { get; set; }
        public Rol RTRoles { get; set; }        
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public Ciudad CiudadId { get; set; }

        public Usuario()
        {

        }
        public Usuario(int UsuarioId,string Cedula, Rol RTRoles, string Nombres, string Apellido1, string Apellido2, string Direccion,string Sexo,string Email,string Telefono, int Edad,string Clave,DateTime FechaIngreso, bool Estado, Ciudad IdCiudad)
        {
            this.Cedula = Cedula;
            this.RTRoles = RTRoles;
            this.Nombres = Nombres;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Direccion = Direccion;
            this.Sexo = Sexo;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Edad = Edad;
            this.Clave = Clave;
            this.FechaIngreso = FechaIngreso;
            this.Estado = Estado;
            this.CiudadId = IdCiudad;
        }

    }
}
