using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;


namespace CapaConexionDatos
{
    public class UsuarioDAO
    {
        #region"PATRON SINGLETON"
        private static UsuarioDAO daoUsuario = null;
        private UsuarioDAO() { }
        public static UsuarioDAO getInstance()
        {
            if (daoUsuario == null)
            {
                daoUsuario = new UsuarioDAO();
            }
            return daoUsuario;
        }

        #endregion
        public Usuario AccesoSistema(string Id, string Pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Usuario objUsuario = null;
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmId", Id);
                cmd.Parameters.AddWithValue("@prmPass", Pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.Id = Convert.ToInt32(dr["Id_Usuario"].ToString());
                    objUsuario.Email = dr["Email"].ToString();
                    objUsuario.Clave = dr["Clave"].ToString();
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;

            }
            finally
            {
                conexion.Close();
            }
            return objUsuario;
        }
    }
}