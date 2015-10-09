<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarTipoMovimientoSancion.aspx.cs" Inherits="insertarTipoMovimientoSancion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h3>Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:LinkButton ID="btnInsertarTipoMovimientoSancion" runat="server" Text="Insertar Tipo Movimiento" OnClick="btnInsertarTipoMovimientoSancion_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
