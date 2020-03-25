using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Rol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Rol()
        {

        }
        public Rol(int ID, string Descripcion, bool Estado)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
        }
    }
}
