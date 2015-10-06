<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComprobacionPR.aspx.cs" Inherits="ExamenWeb.Pages.ComprobacionPR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Comproabación de la prueba rapida</title>
</head>
<body>
    <form id="CompPrueRap" runat="server">
    <div>
        <asp:Label ID="label1" runat="server" Text="¿Está seguro que desea iniciar la prueba rapida?"></asp:Label>
        <br />
        <asp:Button ID="Si" runat="server" Text="Si" onclick="Si_Click" />
        <asp:Button ID="No" runat="server" Text="No" onclick="No_Click" />
    </div>
    </form>
</body>
</html>
