<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarCorredor.aspx.cs" Inherits="insertarCorredor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h5>Identificación: <asp:TextBox ID="txtIdentificacionInsertarCorredor" runat="server"></asp:TextBox> </h5>
        <h5>Nombre: <asp:TextBox ID="txtNombreInsertarCorredor" runat="server"></asp:TextBox> </h5>
        <h5>Alias: <asp:TextBox ID="txtAliasInsertarCorredor" runat="server"></asp:TextBox> </h5>
        <h5>Email: <asp:TextBox ID="txtEmailInsertarCorredor" runat="server"></asp:TextBox></h5
        <h5>Contrasena: <asp:TextBox ID="txtContrasenaInsertarCorredor" runat="server"></asp:TextBox></h5>
        <h5>Genero: <asp:TextBox ID="txtGeneroInsertarCorredor" runat="server"></asp:TextBox></h5>
        <h5>Fecha de nacimiento: <asp:TextBox ID="txtFechaInsertarCorredor" runat="server"></asp:TextBox></h5>
        <asp:LinkButton ID="btnInsertarCorredor" runat="server" Text="Insertar Corredor" OnClick="btnInsertarCorredor_Click"></asp:LinkButton>
        
    </div>
    </form>
</body>
</html>
