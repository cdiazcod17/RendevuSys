<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CapaPresentacion.login" %>

<!DOCTYPE html>

<html class="bg-black">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <meta name="viewport content=width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" /><!--RESPONSIVE-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" type="text/css"/>
    <link href=" https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.1/css/fontawesome.min.css" rel="stylesheet" type="text/css" />
    <link href="code.ionicframework.com/ionicons/1.5.2/css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css"/>
    <style>
    .red2{
            background-color:#e50725 !important;
            color:white;
         }
    </style>

</head>
<body class="bg-black">
    <div class="form-box" id="login-box">
        <div class="header red2">Login</div>   
        <form id="form1" runat="server">
        <div class="body bg-gray">
            <div class="form-group">
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese Uusario"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Ingrese Contraseña"></asp:TextBox>
            </div>
        </div>
            <div class="footer">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-block red2 text-xl-center " OnClick="btnIngresar_Click"/>
            </div>
    </form>
        <h5 style="text-align:center">Si no cuenta con usuario y contraseña hable con el administrador de sede</h5>
        <div class="pull-left">
            <img src="img/praxisimg3-2.png" alt="Visita www.praxis.edu.co"/>
        </div>
        <div class="pull-right">
            <img src="img/LogoRV.png" alt="visita Rendevu Sistems" />
        </div>
   </div>
</body>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js" type="text/javascript"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" type="text/javascript"></script>
<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" type="text/javascript"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" ></script>
<script src="js/AdminLTE/app.js" type="text/javascript"></script>
</html>
