<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menú estudiante.aspx.cs" Inherits="Examen_web.Páginas.Menú_estudiante" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Width="137px">
            Menú de estudiante</asp:Panel>
    
    </div>

    <asp:Button ID="btnexamen" runat="server" Text="Examen" 
        style="margin-top: 0px" />
    &nbsp;&nbsp;
    <asp:Button ID="btnpruebarapida" runat="server" onclick="btnpruebarapida_Click" 
        Text="Prueba rápida" />

        
    </form>
</body>
</html>
