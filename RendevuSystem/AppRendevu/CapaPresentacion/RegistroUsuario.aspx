<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="CapaPresentacion.RegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="content-header">
    <h1 style="text-align:center">REGISTRO DE USUARIOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DOCUMENTO DE IDENTIDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>NOMBRES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                        <div class="form-group">
                            <label>PRIMER APELLIDO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrimerAp" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                        <div class="form-group">
                            <label>SEGUNDO APELLIDO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtSegundoAp" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                        <div class="form-group">
                            <label>DIRECCION</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <div class="form-group">
                            <label>SEXO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLSexo" runat="server" CssClass="form-control">
                                <asp:ListItem>Masculino</asp:ListItem>
                                <asp:ListItem>Femenino</asp:ListItem>
                            </asp:DropDownList> 
                        </div>
                        <div class="form-group">
                            <label>TELEFONO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                        <div class="form-group">
                            <label>EDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEdad" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                        <div class="form-group">
                            <label>EMAIL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                        <div class="form-group">
                            <label>FECHA INGRESO</label>
                        </div>
                        <div class="form-group">
                            <asp:Calendar id="dateCa" runat="server"></asp:Calendar>
                        </div>
                        <div class="form-group">
                            <label>CLAVE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" Text=""></asp:TextBox> 
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
            <div align="center">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnRegistrar" runat="server"  CssClass="btn-blue" Width="200px" Text="Registrar" OnClick="btnRegistrar_Click"/>
                        </td>                        
                       <td>&nbsp;&nbsp;&nbsp;&nbsp;</td> 
                        <td>
                            <asp:Button ID="btnCancelar" runat="server"  CssClass="red3" Width="200px" Text="Cancelar" />
                        </td>
                    </tr>
                </table>
            </div> 
        
    </section>
</asp:Content>
