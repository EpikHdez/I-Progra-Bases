<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menú profesor.aspx.cs" Inherits="Examen_web.Páginas.Menú_profesor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btn_preguntas" runat="server" onclick="btn_preguntas_Click" 
            Text="Preguntas" />
        <asp:Button ID="btn_estudiantes" runat="server" onclick="btn_estudiantes_Click" 
            Text="Registro de estudiantes" />
        <asp:Button ID="btn_examen" runat="server" onclick="btn_examen_Click" 
            Text="Examen" />
        <asp:Button ID="btn_pruebarap" runat="server" onclick="btn_pruebarap_Click" 
            Text="Prueba Rapida" />
    
    </div>
    </form>
</body>
</html>
