<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComprobacionP.aspx.cs" Inherits="ExamenWeb.Pages.ComprobacionP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="CompPrueb" runat="server">
    <div>
        <asp:Label ID="label1" runat="server" Text="¿Está seguro que desea iniciar la prueba?"></asp:Label>
        <br />
        <asp:Button ID="Si" runat="server" Text="Si" />
        <asp:Button ID="No" runat="server" Text="No" onclick="No_Click" />
    </div>
    </form>
</body>
</html>
