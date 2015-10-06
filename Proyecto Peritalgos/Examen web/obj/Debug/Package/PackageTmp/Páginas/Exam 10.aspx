<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 10.aspx.cs" Inherits="Examen_web.Páginas.Exam_10" %>

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
        <asp:Panel ID="Panel46" runat="server">
        <asp:Image ID="Image46" runat="server" />
        <br />
            <asp:Label ID="lblpregunta46" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg46" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg46" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg46" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg46" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel47" runat="server">
        <asp:Image ID="Image47" runat="server" />
        <br />
            <asp:Label ID="lblpregunta47" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg47" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg47" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg47" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg47" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel48" runat="server">
        <asp:Image ID="Image48" runat="server" />
        <br />
            <asp:Label ID="lblpregunta48" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg48" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg48" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg48" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg48" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel49" runat="server">
            <asp:Image ID="Image49" runat="server" />
            <br />
            <asp:Label ID="lblpregunta49" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg49" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg49" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg49" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg49" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel50" runat="server">
        <asp:Image ID="Image50" runat="server" />
        <br />
            <asp:Label ID="lblpregunta50" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg50" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg50" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg50" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg50" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
