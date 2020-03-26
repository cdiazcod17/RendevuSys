<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="PanelGeneral.aspx.cs" Inherits="CapaPresentacion.PanelGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align:center">PANEL GENERAL</h1>
    </section> 
    <section class="content">
        <div class="row">
            <div class="col-sm-8 form-inline">
                <div class="box box-danger">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CLAVE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                        </div>
                                                <div class="form-group">
                            <label>CONFIRME CLAVE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtConfClave" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                        </div>
                   </div>
                </div>
            </div>
            </div>
         </section>
     <div align="center">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnRegistrar" runat="server"  CssClass="btn-blue" Width="200px" Text="Cancelar"/>
                        </td>                        
                       <td>&nbsp;&nbsp;&nbsp;&nbsp;</td> 
                        <td>
                            <asp:Button ID="btnCancelar" runat="server"  CssClass="red3" Width="200px" Text="Confirmar" />
                        </td>
                    </tr>
                </table>
            </div>
</asp:Content>
