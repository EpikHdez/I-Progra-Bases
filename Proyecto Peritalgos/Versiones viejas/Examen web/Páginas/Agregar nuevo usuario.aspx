<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar nuevo usuario.aspx.cs" Inherits="Examen_web.Páginas.Agregar_nuevo_usuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="../Resources/fondoazul.jpg">
    <form id="form1" runat="server">
    <asp:Panel ID="Panel2" runat="server">
    </asp:Panel>
    <br />
    Nombre y apellido:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    <br />
    <br />
    Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
    <asp:TextBox ID="txtcontraseña1" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Repita la contraseña:&nbsp;
    <asp:TextBox ID="txtcontraseña2" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Nivel de control:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlnivel" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlnivel_SelectedIndexChanged">
        <asp:ListItem Value="02">Profesor</asp:ListItem>
        <asp:ListItem Value="03">Estudiante</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Especialidad:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlesp_sec" runat="server">
        <asp:ListItem>Informatica</asp:ListItem>
        <asp:ListItem>Contabilidad</asp:ListItem>
        <asp:ListItem>Ejecutivo</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblerror" runat="server" ForeColor="Red" Text="Label" 
        Visible="False"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnguardar" runat="server" onclick="btnguardar_Click" 
        Text="Guardar" />
&nbsp;
    <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
    </form>
    </body>
</html>
