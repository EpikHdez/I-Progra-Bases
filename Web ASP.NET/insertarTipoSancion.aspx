<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarTipoSancion.aspx.cs" Inherits="insertarTipoSancion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h3>Nombre: <asp:TextBox id="txtNombreTipoSancion" runat="server"></asp:TextBox></h3>
        <asp:button id="btnCrearTipoSancion" runat="server" text="Crear Sancion" OnClick="botonCrearTipoSancion_Click"/>
        <asp:Label ID="lblSancion" runat="server">Hola</asp:Label>
    
    </div>
    </form>
</body>
</html>
