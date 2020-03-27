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
        public Usuario AccesoSistema(string Cedula, string Pass)
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
                cmd.Parameters.AddWithValue("@prmCedula", Cedula);                
                cmd.Parameters.AddWithValue("@prmPass", Pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.Cedula = dr["Cedula"].ToString();
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

        /*public bool RegistrarUsuario(Usuario objUsuario)
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
                cmd.Parameters.AddWithValue("@prmEstado", objUsuario.Estado);
                cmd.Parameters.AddWithValue("@prmId_Ciudad", objUsuario.IdCiudad);
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

        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> ListaUs = new List<Usuario>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spListaUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Usuario objUsuario = new Usuario();
                    objUsuario.Cedula = dr["Cedula"].ToString());
                    objUsuario.Nombres = dr["Nombres"].ToString();
                    objUsuario.Apellido1 = dr["Apellido1"].ToString();
                    objUsuario.Apellido2 = dr["Apellido2"].ToString();
                    objUsuario.Edad = Convert.ToInt32(dr["Edad"].ToString());
                    objUsuario.Sexo = (dr["Sexo"].ToString());
                    objUsuario.Direccion = dr["Direccion"].ToString();
                    objUsuario.Email = dr["Email"].ToString();
                    objUsuario.Telefono = dr["Telefono"].ToString();
                    objUsuario.Estado = true;

                    ListaUs.Add(objUsuario);
                }
                            
            }
            catch (Exception Ex)
            {             
                throw Ex;
            }
            finally
            {
                con.Close();
            }
            return ListaUs;
        }

       /* public Usuario EliminarUsuario()
        {

        }*/
    }
}