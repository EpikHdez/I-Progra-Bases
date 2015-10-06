<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 14.aspx.cs" Inherits="Examen_web.Páginas.Exam_14" %>

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
        <asp:Panel ID="Panel66" runat="server">
        <asp:Image ID="Image66" runat="server" />
        <br />
            <asp:Label ID="lblpregunta66" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg66" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg66" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg66" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg66" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel67" runat="server">
        <asp:Image ID="Image67" runat="server" />
        <br />
            <asp:Label ID="lblpregunta67" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg67" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg67" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg67" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg67" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel68" runat="server">
        <asp:Image ID="Image68" runat="server" />
        <br />
            <asp:Label ID="lblpregunta68" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg68" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg68" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg68" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg68" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel69" runat="server">
            <asp:Image ID="Image69" runat="server" />
            <br />
            <asp:Label ID="lblpregunta69" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg69" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg69" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg69" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg69" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel70" runat="server">
        <asp:Image ID="Image70" runat="server" />
        <br />
            <asp:Label ID="lblpregunta70" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg70" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg70" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg70" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg70" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
