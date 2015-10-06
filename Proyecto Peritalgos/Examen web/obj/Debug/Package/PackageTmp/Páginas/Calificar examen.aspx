<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calificar examen.aspx.cs" Inherits="Examen_web.Páginas.Calificar_examen" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Su nota final es de:
    <asp:Label ID="lblnota" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnsalir" runat="server" Text="Salir" 
        onclick="btnsalir_Click" />
    </form>
</body>
</html>
