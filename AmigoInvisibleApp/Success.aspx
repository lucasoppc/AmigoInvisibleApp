<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="AmigoInvisibleApp.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <title>Mi amigo invisible</title>
    <style type="text/css">
        .auto-style1 {
            display: inline;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h1 class="display-3 text-center">Empieza el juego</h1>

        <div id="presentacion" style="width:30%; min-width:100px; float:left; height:300px; margin-left:50px; margin-top:60px;">
            <p style="font-size:24px; margin-top:25px;">Bienvenido, ya estas mas cerca de descubrirme. 
                En esta pagina vas a interactuar para conseguir mas pistas. Suerte!</p>

        </div>

        <div id="unknown" style="display:inline; float:right; margin-top:90px; width:50%;" class="text-center">

        <asp:Image ID="unknownimg" runat="server" Height="250px" ImageUrl="~/images/persona-invisible-de-ropa.png" Width="200px"  />

        </div>

        
        <br style="clear:both;" />

        <div class="auto-style1" style="width:40%; min-width:200px; float:right; margin-right:100px" >

        <asp:TextBox ID="txtNombre" CssClass="form-control input-group float-left d-inline" width="60%" Style="" placeholder="Quien soy?" runat="server" ToolTip="Solo tenes 1 intento por dia"></asp:TextBox>

        <asp:Button ID="btnProbar" CssClass="btn btn-outline-primary d-inline" Width="40%" runat="server" Text="Enviar" />

        </div>

        <hr />

        <div id="pistas">
<h3 class="display-4">Pistas:</h3>
        <asp:GridView ID="gvPistas" runat="server" CssClass="d-inline table table-striped table-borderless" Style="" Height="100px" width="50%" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField HeaderText="Fecha" DataFormatString="d:0" />
                        <asp:ButtonField ButtonType="Button" Text="Ver">
                        <ControlStyle CssClass="btn btn-primary" />
                        </asp:ButtonField>
                    </Columns>
                </asp:GridView>

        <asp:TextBox ID="txtPista" runat="server" Width="40%" Height="200px" Style="margin-right:50px" CssClass=" d-inline d-flex form-control input-group-text" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>

        </div>







    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>

    </form>
</body>
</html>
