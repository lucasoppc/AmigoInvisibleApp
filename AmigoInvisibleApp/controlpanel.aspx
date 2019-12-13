<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="controlpanel.aspx.cs" Inherits="AmigoInvisibleApp.controlpanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="Preguntas recibidas:" style="width:100%;">
<h3 class="auto-style2">PISTAS:</h3>
        <asp:GridView ID="gvPistas" runat="server" CssClass=" table table-borderless" Style="" Height="100px" width="100%" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField HeaderText="Fecha" DataFormatString="{0:t}" DataField="Fecha" />
                        <asp:BoundField DataField="Texto" HeaderText="Descripcion" />
                    </Columns>
                </asp:GridView>

        </div>
            <br />
            <div>
                Ingresar Pista: <asp:TextBox ID="txtPista" width="50%" runat="server"></asp:TextBox><asp:Button ID="btnEnviarPista" runat="server" Text="Enviar" OnClick="btnEnviarPista_Click" />
            </div>
            <br />
            <div>
                <asp:Label ID="lblEstado" runat="server" Text="Estado desconocido"></asp:Label>
            </div>
            <br />
            <div>
                <asp:Label ID="lblDialogo" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
