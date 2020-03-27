using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Rol
    {
        public int Id_Rol { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Rol()
        {

        }
        public Rol(int Id_Rol, string Descripcion, bool Estado)
        {
            this.Id_Rol = Id_Rol;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
        }
    }
}
