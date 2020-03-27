using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaConexionDatos;

namespace CapaLogNegocio
{
    public class UsuarioLN
    {
        #region"PATRON SINGLETON"
        private static UsuarioLN objUsuario = null;
        private UsuarioLN() { }
        public static UsuarioLN getInstance()
        {
            if (objUsuario == null)
            {
                objUsuario = new UsuarioLN();
            }
            return objUsuario;
        }

        #endregion

        public Usuario AccesoSistema(string Cedula, string Pass)
        {
            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(Cedula,Pass);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        /*public bool RegistrarUsuario(Usuario objUsuario)
        {
            try
            {
                return UsuarioDAO.getInstance().RegistrarUsuario(objUsuario);
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
            
        }

        public List<Usuario> ListaUsuarios()
        {
            try
            {
                return UsuarioDAO.getInstance().ListaUsuarios();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }*/


    }
}

