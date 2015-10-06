<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 11.aspx.cs" Inherits="Examen_web.Páginas.Exam_11" %>

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
        <asp:Panel ID="Panel47" runat="server">
        <asp:Image ID="Image51" runat="server" />
        <br />
            <asp:Label ID="lblpregunta51" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg51" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg51" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg51" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg51" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel52" runat="server">
        <asp:Image ID="Image52" runat="server" />
        <br />
            <asp:Label ID="lblpregunta52" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg52" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg52" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg52" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg52" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel53" runat="server">
        <asp:Image ID="Image53" runat="server" />
        <br />
            <asp:Label ID="lblpregunta53" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg53" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg53" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg53" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg53" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel54" runat="server">
            <asp:Image ID="Image54" runat="server" />
            <br />
            <asp:Label ID="lblpregunta54" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg54" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg54" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg54" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg54" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel55" runat="server">
        <asp:Image ID="Image55" runat="server" />
        <br />
            <asp:Label ID="lblpregunta55" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg55" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg55" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg55" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg55" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
