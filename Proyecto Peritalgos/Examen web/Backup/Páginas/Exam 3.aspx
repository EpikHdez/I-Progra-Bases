<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 3.aspx.cs" Inherits="Examen_web.Páginas.Exam_3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Tiempo" runat="server" Interval="1000" ontick="Tiempo_Tick">
                </asp:Timer>
                <asp:TextBox ID="txthoras" runat="server" Enabled="False" Width="24px">01</asp:TextBox>
                :<asp:TextBox ID="txtmin" runat="server" Enabled="False" Width="24px">59</asp:TextBox>
                :<asp:TextBox ID="txtseg" runat="server" Enabled="False" Width="24px">59</asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:Panel ID="Panel11" runat="server">
            <asp:Label ID="lblpregunta11" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg11" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg11" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg11" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg11" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel12" runat="server">
            <asp:Label ID="lblpregunta12" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg12" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg12" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg12" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg12" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel13" runat="server">
            <asp:Label ID="lblpregunta13" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg13" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg13" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg13" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg13" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel14" runat="server">
            <asp:Image ID="imgpreg14" runat="server" />
            <br />
            <asp:Label ID="lblpregunta14" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg14" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg14" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg14" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg14" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel15" runat="server">
        <asp:Image ID="Imgpreg15" runat="server" />
        <br />
            <asp:Label ID="lblpregunta15" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg15" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg15" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg15" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg15" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
