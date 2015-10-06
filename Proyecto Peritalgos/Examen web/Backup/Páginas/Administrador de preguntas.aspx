<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador de preguntas.aspx.cs" Inherits="Examen_web.Páginas.Administrador_de_preguntas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Escriba el numero de pregunta:
        <asp:DropDownList ID="ddl_numpreg" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddl_numpreg_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="lbl_imagen" runat="server" Text="Imagen: " Visible="False"></asp:Label>
&nbsp;<asp:Image ID="ib_preg" runat="server" />
        <asp:FileUpload id="FileUploadControl" runat="server" Visible="false" />
         <asp:Button runat="server" id="UploadButton" text="Subir" onclick="UploadButton_Click" Visible="false" />
    </p>
    <p>
        <asp:Label ID="lbl_pregunta" runat="server" Text="Pregunta: " Visible="False"></asp:Label>
        <asp:TextBox ID="txt_pregunta" runat="server" ReadOnly="True" Visible="False" 
            Width="885px"></asp:TextBox>
    </p>
    <p>
        &nbsp;<asp:Label ID="lbl_opcion1" runat="server" Text="Opción 1: " 
            Visible="False"></asp:Label>
        <asp:TextBox ID="txt_op1" runat="server" ReadOnly="True" Visible="False" 
            Width="885px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_opcion2" runat="server" Text="Opción 2: " Visible="False"></asp:Label>
        <asp:TextBox ID="txt_op2" runat="server" ReadOnly="True" Visible="False" 
            Width="885px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_opcion3" runat="server" Text="Opción 3:" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_op3" runat="server" ReadOnly="True" Visible="False" 
            Width="885px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_opcion4" runat="server" Text="Opción 4: " Visible="False"></asp:Label>
        <asp:TextBox ID="txt_op4" runat="server" ReadOnly="True" Visible="False" 
            Width="885px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_respuesta" runat="server" Text="Respuesta: " Visible="False"></asp:Label>
        <asp:TextBox ID="txt_respuesta" runat="server" ReadOnly="True" Visible="False" 
            Width="885px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_editar" runat="server" onclick="btn_editar_Click" 
            Text="Editar" />
        &nbsp;<asp:Button ID="btn_guardar" runat="server" onclick="btn_guardar_Click" 
            Text="Guardar" Visible="False" />
    &nbsp;<asp:Button ID="btn_atras" runat="server" onclick="btn_atras_Click" 
            Text="Atrás" />
    </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
