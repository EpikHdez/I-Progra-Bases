<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calificar prueba rapida.aspx.cs" Inherits="Examen_web.Páginas.Calificar_prueba_rapida" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Tu puntuación es:
        <asp:Label ID="lbl_nota" runat="server" Text="Label"></asp:Label>
    
        <br />
    
    </div>
    <asp:Button ID="btn_salir" runat="server" onclick="btn_salir_Click" 
        Text="Salir" Width="58px" />
    </form>
</body>
</html>
