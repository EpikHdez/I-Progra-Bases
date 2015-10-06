<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ExamenWeb.Pages.Inicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Styles/Site.css" rel="stylesheet" type="text/css" />
    <title>Inicio</title>
</head>
<body>
    <form id="Inicio" runat="server">
    <div>
    <h1>Seleccione una opción</h1>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Button ID="IniPrueba" runat="server" Text="Iniciar Prueba" 
                onclick="IniPrueba_Click" />
            <asp:Button ID="PruebRapid" runat="server" Text="Prueba Rapida" 
                onclick="PruebRapid_Click" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
