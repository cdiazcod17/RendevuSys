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

        public Usuario AccesoSistema(string Id, string Pass)
        {
            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(Id, Pass);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


    }
}

