<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppLogin.aspx.cs" Inherits="ServiceDeskWeb.AppLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link rel="stylesheet" type="text/css" href="scripts/css/materialize.min.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/login.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/fonts.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/animated.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/load.css" />
    <script src="scripts/js/Jquery.js"></script>
    <script src="scripts/js/materialize.min.js"></script>
<%--</head>--%>
<body>

    <!-- Modal Structure -->
    <div id="modalLoad" class="modal modalload">
        <div class="modal-content">
            <div class="lds-spinner">
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
                <div></div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col s12">
            <h2>ServiceDesk</h2>
        </div>
    </div>
    <div class="fmLogin">
        <div class="row">
            <form class="col s12 frmLoginInputs" id="formLogin" runat="server">
                <div class="row">
                    <div class="input-field col s12">
                        <asp:TextBox runat="server" ID="tbLogin" class="validate" />
                        <label for="tbLogin">Login</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col s12">
                        <asp:TextBox runat="server" ID="password" type="password" class="validate" />
                        <label for="password">Senha</label>
                    </div>
                </div>
                <div class="row divButtons">
                    <div class="col s12">
                        <asp:LinkButton Text="Entrar" runat="server" class="waves-effect waves-light btn" ID="btnEntrar" OnClick="btnEntrar_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>

<script src="scripts/js/login.js"></script>
</html>
