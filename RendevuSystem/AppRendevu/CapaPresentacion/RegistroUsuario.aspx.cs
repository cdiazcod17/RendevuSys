using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaPresentacion;
using CapaLogNegocio;

namespace CapaPresentacion
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }
        private Usuario GetEntidad()
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Id = Convert.ToInt32(txtId.Text);
            objUsuario.Nombres = txtNombres.Text;
            objUsuario.Apellido1 = txtPrimerAp.Text;
            objUsuario.Apellido2 = txtSegundoAp.Text;
            objUsuario.Direccion = txtDireccion.Text;
            objUsuario.Sexo = DDLSexo.SelectedValue;
            objUsuario.Email = txtEmail.Text;
            objUsuario.Telefono = txtTelefono.Text;
            objUsuario.Edad = Convert.ToInt32(txtEdad.Text);
            objUsuario.Clave = txtClave.Text;
            objUsuario.FechaIngreso = dateCa.SelectedDate;
            objUsuario.Estado = true;

            return objUsuario;

        }
        private Usuario GetRegUsuario()
        {
            return null;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = GetEntidad();
            bool response = UsuarioLN.getInstance().RegistrarUsuario(objUsuario);
            if (response == true)
            {
                Response.Write("<Script>alert('USUARIO REGISTRADO')</Script>");
            }
            else
            {
                Response.Write("<Script>alert('USUARIO INCORRECTO')</Script>");
            }
        }
    }
}