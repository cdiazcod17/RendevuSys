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

        public bool RegistrarUsuario(Usuario objUsuario)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;          

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmID", objUsuario.Id);
                cmd.Parameters.AddWithValue("@prmNombres", objUsuario.Nombres);
                cmd.Parameters.AddWithValue("@prmApellido1", objUsuario.Apellido1);
                cmd.Parameters.AddWithValue("@prmApellido2", objUsuario.Apellido2);
                cmd.Parameters.AddWithValue("@prmDireccion", objUsuario.Direccion);
                cmd.Parameters.AddWithValue("@prmSexo", objUsuario.Sexo);
                cmd.Parameters.AddWithValue("@prmEmail", objUsuario.Email);
                cmd.Parameters.AddWithValue("@prmTelefono", objUsuario.Telefono);
                cmd.Parameters.AddWithValue("@prmEdad", objUsuario.Edad);
                cmd.Parameters.AddWithValue("@prmClave", objUsuario.Clave);
                cmd.Parameters.AddWithValue("@prmFechaIngreso", objUsuario.FechaIngreso);
                cmd.Parameters.AddWithValue("@prmFechaEstado", objUsuario.Estado);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch(Exception Ex)
            {
                response = false;
                throw Ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }

        public bool list<Usuario> ListaUsuarios()
        {
            List<Usuario> Lista = new List<Usuario>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spListaUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Usuario objUsuario = new Usuario();
                    objUsuario.
                }

                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch (Exception Ex)
            {
                response = false;
                throw Ex;
            }
            finally
            {
                con.Close();
            }
            return response;

        }
    }
}