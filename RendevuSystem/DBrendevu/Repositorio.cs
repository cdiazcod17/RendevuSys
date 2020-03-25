using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBrendevu
{
    public class Repositorio
    {
        private ContextDBrendevu _Context;

        public Repositorio()
        {
            _Context = new ContextDBrendevu();
        }
        public List<Usuarios> GetUsuarios()
        {
            List<Usuarios> ListaUsuarios = _Context.Usuarios.ToList();
            return ListaUsuarios;
        }
    }
}