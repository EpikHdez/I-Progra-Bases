<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h5>Por favor escoja el menú al que desea ingresar: </h5>
        <asp:LinkButton ID="btnMenuCampeonato" runat="server" Text="Menú de campeonatos" OnClick="btnMenuCampeonato_Click"></asp:LinkButton>
        <br />
        <asp:LinkButton ID="btnMenuCatalogos" runat="server" Text="Menú de catálogos" OnClick="btnMenuCatalogos_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>