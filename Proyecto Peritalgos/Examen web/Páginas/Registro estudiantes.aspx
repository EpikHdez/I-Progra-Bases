<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro estudiantes.aspx.cs" Inherits="Examen_web.Páginas.Registro_estudiantes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nombre:
        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
    
    &nbsp;&nbsp; Sección:
        <asp:DropDownList ID="ddl_seccion" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Busqueda" 
            onclick="Button1_Click" />
        <br />
&nbsp;<asp:Panel 
            ID="pnl_registro" runat="server" Visible="False">
            <asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label>
            &nbsp;<asp:Label ID="lbl_seccion" runat="server" Text="Seccion"></asp:Label>
            <br />
            <table>
            <tr>
            <td>
            Preg 1:&nbsp;
            <asp:Label ID="lbl_preg2" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 2:&nbsp;
            <asp:Label ID="lbl_preg1" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 3:&nbsp;
            <asp:Label ID="lbl_preg3" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 4:&nbsp;
            <asp:Label ID="lbl_preg4" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 5:&nbsp;
            <asp:Label ID="lbl_preg5" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 6:&nbsp;
            <asp:Label ID="lbl_preg6" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 7:&nbsp;
            <asp:Label ID="lbl_preg7" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 8:&nbsp;
            <asp:Label ID="lbl_preg8" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 9:&nbsp;
            <asp:Label ID="lbl_preg9" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 10:&nbsp;
            <asp:Label ID="lbl_preg10" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 11:&nbsp;
            <asp:Label ID="lbl_preg11" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 12:&nbsp;
            <asp:Label ID="lbl_preg12" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 13:&nbsp;
            <asp:Label ID="lbl_preg13" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 14:&nbsp;
            <asp:Label ID="lbl_preg14" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 15:&nbsp;
            <asp:Label ID="lbl_preg15" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 16:&nbsp;
            <asp:Label ID="lbl_preg16" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 17:&nbsp;
            <asp:Label ID="lbl_preg17" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 18:&nbsp;
            <asp:Label ID="lbl_preg18" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 19:&nbsp;
            <asp:Label ID="lbl_preg19" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 20:&nbsp;
            <asp:Label ID="lbl_preg20" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 21:&nbsp;
            <asp:Label ID="lbl_preg21" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 22:&nbsp;
            <asp:Label ID="lbl_preg22" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 23:&nbsp;
            <asp:Label ID="lbl_preg23" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 24:&nbsp;
            <asp:Label ID="lbl_preg24" runat="server" Text="Label"></asp:Label>
            <br />
             Preg 25:&nbsp;
            <asp:Label ID="lbl_preg25" runat="server" Text="Label"></asp:Label>
            <br />
            </td>
            <td class="style1"></td>
            <td>
                <br />
            Preg 26:&nbsp;
            <asp:Label ID="lbl_preg26" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 27:&nbsp;
            <asp:Label ID="lbl_preg27" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 28:&nbsp;
            <asp:Label ID="lbl_preg28" runat="server" Text="Label"></asp:Label>
            <br />
            Preg 29:&nbsp;
            <asp:Label ID="lbl_preg29" runat="server" Text="Label"></asp:Label>
            <br />
                Preg 30:&nbsp;
                <asp:Label ID="lbl_preg30" runat="server" Text="Label"></asp:Label>
            <br />
                Preg 31:&nbsp;
                <asp:Label ID="lbl_preg31" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 32:&nbsp;
                <asp:Label ID="lbl_preg32" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 33:&nbsp;
                <asp:Label ID="lbl_preg33" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 34:&nbsp;
                <asp:Label ID="lbl_preg34" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 35:&nbsp;
                <asp:Label ID="lbl_preg35" runat="server" Text="Label"></asp:Label>
            <br />
                Preg 36:&nbsp;
                <asp:Label ID="lbl_preg36" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 37:&nbsp;
                <asp:Label ID="lbl_preg37" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 38:&nbsp;
                <asp:Label ID="lbl_preg38" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 39:&nbsp;
                <asp:Label ID="lbl_preg39" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 40:&nbsp;
                <asp:Label ID="lbl_preg40" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 41:&nbsp;
                <asp:Label ID="lbl_preg41" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 42:&nbsp;
                <asp:Label ID="lbl_preg42" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 43:&nbsp;
                <asp:Label ID="lbl_preg43" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 44:&nbsp;
                <asp:Label ID="lbl_preg44" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 45:&nbsp;
                <asp:Label ID="lbl_preg45" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 46:&nbsp;
                <asp:Label ID="lbl_preg46" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 47:&nbsp;
                <asp:Label ID="lbl_preg47" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 48:&nbsp;
                <asp:Label ID="lbl_preg48" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 49:&nbsp;
                <asp:Label ID="lbl_preg49" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 50:&nbsp;
                <asp:Label ID="lbl_preg50" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
            </td>
            <td class="style1"></td>
            <td>
            
                Preg 51:&nbsp;
                <asp:Label ID="lbl_preg51" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 52:&nbsp;
                <asp:Label ID="lbl_preg52" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 53:&nbsp;
                <asp:Label ID="lbl_preg53" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 54:&nbsp;
                <asp:Label ID="lbl_preg54" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 55:&nbsp;
                <asp:Label ID="lbl_preg55" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 56:&nbsp;
                <asp:Label ID="lbl_preg56" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 57:&nbsp;
                <asp:Label ID="lbl_preg57" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 58:&nbsp;
                <asp:Label ID="lbl_preg58" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 59:&nbsp;
                <asp:Label ID="lbl_preg59" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 60:&nbsp;
                <asp:Label ID="lbl_preg60" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 61:&nbsp;
                <asp:Label ID="lbl_preg61" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 62:&nbsp;
                <asp:Label ID="lbl_preg62" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 63:&nbsp;
                <asp:Label ID="lbl_preg63" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 64:&nbsp;
                <asp:Label ID="lbl_preg64" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 65:&nbsp;
                <asp:Label ID="lbl_preg65" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 66:&nbsp;
                <asp:Label ID="lbl_preg66" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 67:&nbsp;
                <asp:Label ID="lbl_preg67" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 68:&nbsp;
                <asp:Label ID="lbl_preg68" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 69:&nbsp;
                <asp:Label ID="lbl_preg69" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 70:&nbsp;
                <asp:Label ID="lbl_preg70" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 71:&nbsp;
                <asp:Label ID="lbl_preg71" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 72:&nbsp;
                <asp:Label ID="lbl_preg72" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 73:&nbsp;
                <asp:Label ID="lbl_preg73" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 74:&nbsp;
                <asp:Label ID="lbl_preg74" runat="server" Text="Label"></asp:Label>
                <br />
                Preg 75:&nbsp;
                <asp:Label ID="lbl_preg75" runat="server" Text="Label"></asp:Label>
                <br />
            
            </td>
            </tr>
            </table>
        </asp:Panel>
        <asp:Button ID="btn_atras" runat="server" onclick="btn_atras_Click" 
            Text="Atrás" />
        <br />
        <br />


    </div>
    </form>
</body>
</html>
