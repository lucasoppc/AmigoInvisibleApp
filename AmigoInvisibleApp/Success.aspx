<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="AmigoInvisibleApp.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <title>Mi amigo invisible</title>
</head>
<body>
    <form id="form1" runat="server">

        <h1 class="display-3 text-center">Empieza el juego</h1>

        <div id="presentacion" style="width:30%; min-width:100px; float:left; height:300px; margin-left:50px; margin-top:60px;">
            <p style="font-size:24px; margin-top:25px;">Bienvenido, ya estas mas cerca de descubrirme. 
                En esta pagina vas a interactuar para conseguir mas pistas. Suerte!</p>
        </div>

        <div id="unknown" style="display:inline; float:right; margin-top:90px;">
            <asp:Image ID="unknownimg" runat="server" Height="250px" style="float:right; margin-right:100px;" ImageAlign="Right" ImageUrl="~/images/persona-invisible-de-ropa.png" Width="200px"  />
        </div>
        

        <br style="clear:both;" />





    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>

    </form>
</body>
</html>
