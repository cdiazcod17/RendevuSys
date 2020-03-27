<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="CapaPresentacion.ConsultaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="text-center">CONSULTA DE USUARIOS</h4>
    <asp:Button ID="btnBuscarUsuario" runat="server" Text="Buscar" />
    <asp:TextBox ID="TextBox1" PlaceHolder="Buscar" runat="server" ></asp:TextBox> 
    <div>
    <asp:GridView ID="gbvListaUsuario" CssClass="gridView" runat="server" Width="927px" AutoGenerateColumns="False" OnRowCommand="gbListaUsuario_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Código" DataField="Id" />
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" />
                <asp:BoundField HeaderText="Apellidos" DataField="Apellido1 + Apellido2" />
                <asp:BoundField HeaderText="Edad" DataField="Edad" />
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" />
                <asp:TemplateField HeaderText="Acciones" >
                    <ItemTemplate>
                        <asp:ImageButton CommandName="Actualizar" ImageUrl="~/img/Actualizar.png" Width="22px" ID="imgActualizar" runat="server" />
                        <asp:ImageButton CommandName="Eliminar" ImageUrl="~/img/Eliminar.png" Width="22px" ID="imgEliminar" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
</asp:Content>
