<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 5.aspx.cs" Inherits="Examen_web.Páginas.Exam_5" %>

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
        <asp:Panel ID="Panel21" runat="server">
        <asp:Image ID="Image21" runat="server" />
        <br />
            <asp:Label ID="lblpregunta21" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg21" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg21" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg21" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg21" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel22" runat="server">
        <asp:Image ID="Image22" runat="server" />
        <br />
            <asp:Label ID="lblpregunta22" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg22" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg22" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg22" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg22" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel23" runat="server">
        <asp:Image ID="Image23" runat="server" />
        <br />
            <asp:Label ID="lblpregunta23" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg23" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg23" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg23" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg23" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel24" runat="server">
            <asp:Image ID="Image24" runat="server" />
            <br />
            <asp:Label ID="lblpregunta24" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg24" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg24" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg24" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg24" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel25" runat="server">
        <asp:Image ID="Image25" runat="server" />
        <br />
            <asp:Label ID="lblpregunta25" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg25" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg25" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg25" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg25" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
