<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuCatalogo.aspx.cs" Inherits="menuCatalogo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:LinkButton ID="menuTipoMovimientoSancion" runat="server" Text="Menú Tipo Movimiento Sanción" OnClick="menuTipoMovimientoSancion_Click"></asp:LinkButton><br />
        <asp:LinkButton ID="menuTipoMovimientoPuntos" runat="server" Text="Menú Tipo Movimiento Puntos" OnClick="menuTipoMovimientoPuntos_Click"></asp:LinkButton><br />
        <asp:LinkButton ID="menuTipoSancion" runat="server" Text="Menú Tipo Sanción" OnClick="menuTipoSancion_Click"></asp:LinkButton><br />
    
    </div>
    </form>
</body>
</html>
