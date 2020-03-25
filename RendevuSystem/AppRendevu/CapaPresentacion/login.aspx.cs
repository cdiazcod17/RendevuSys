using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogNegocio;

namespace CapaPresentacion
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = UsuarioLN.getInstance().AccesoSistema(txtUsuario.Text, txtPassword.Text);
            if(objUsuario != null)
            {
                Response.Write("<Script>alert('USUARIO CORRECTO')</Script>");
                Response.Redirect("index.aspx");

            }
            else
            {
                Response.Write("<Script>alert('USUARIO INCORRECTO')</Script>");
            }
        }
    }
}