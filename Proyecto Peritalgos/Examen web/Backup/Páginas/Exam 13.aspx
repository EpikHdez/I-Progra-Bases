<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 13.aspx.cs" Inherits="Examen_web.Páginas.Exam_13" %>

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
        <asp:Panel ID="Panel61" runat="server">
        <asp:Image ID="Image61" runat="server" />
        <br />
            <asp:Label ID="lblpregunta61" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg61" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg61" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg61" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg61" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel62" runat="server">
        <asp:Image ID="Image62" runat="server" />
        <br />
            <asp:Label ID="lblpregunta62" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg62" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg62" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg62" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg62" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel63" runat="server">
        <asp:Image ID="Image63" runat="server" />
        <br />
            <asp:Label ID="lblpregunta63" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg63" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg63" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg63" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg63" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel64" runat="server">
            <asp:Image ID="Image64" runat="server" />
            <br />
            <asp:Label ID="lblpregunta64" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg64" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg64" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg64" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg64" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel65" runat="server">
        <asp:Image ID="Image65" runat="server" />
        <br />
            <asp:Label ID="lblpregunta65" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg65" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg65" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg65" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg65" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
