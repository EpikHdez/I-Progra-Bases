<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarTipoMovimientoPuntos.aspx.cs" Inherits="insertarTipoMovimientoPuntos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h3>Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> </h3>
        <<asp:LinkButton ID="btnInsertarMovimientoPuntos" runat="server" Text="Insertar Movimiento Puntos" OnClick="btnInsertarMovimientoPuntos_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
