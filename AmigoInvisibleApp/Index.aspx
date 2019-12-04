﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AmigoInvisibleApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form runat="server" id="hola">
        <div class="text-left">
    <h2 class="display-2 text-center">Hola Mundo</h2>
    <br />
    <hr />
    <br />
        <h6 class="text-center font-weight-bold">Ingrese el codigo para empezar</h6>
    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control w-25 m-auto"></asp:TextBox>
        <br />
        <asp:Button ID="btnProbar" runat="server" Text="Probar Suerte!" CssClass="btn btn-primary d-block" style="width:25%; margin:auto;"/>



    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
        </div>
    </form>
</body>
</html>