using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogNegocio;
using CapaConexionDatos;


namespace CapaPresentacion
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }
            /*public static List<Usuario> ListaUsuarios()
            {
                List<Usuario> Lista = null;
                try
                {
                    Lista = UsuarioLN.getInstance().ListaUsuarios();
                }
                catch (Exception)
                {
                    Lista = null;
                }
                return Lista;
            }
        

        protected void gbListaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)    
        {
            
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int Indice = fila.RowIndex;
            if (e.CommandName == "Eliminar")
            {
                int Id = Convert.ToInt32(gbvListaUsuario.Rows[Indice].Cells[0].Text);
                
            }
        }*/
    }
}