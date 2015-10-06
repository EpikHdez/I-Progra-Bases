<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 4.aspx.cs" Inherits="Examen_web.Páginas.Exam_4" %>

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
        <asp:Panel ID="Panel16" runat="server">
        <asp:Image ID="Image16" runat="server" />
        <br />
            <asp:Label ID="lblpregunta16" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg16" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg16" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg16" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg16" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel17" runat="server">
        <asp:Image ID="Image17" runat="server" />
        <br />
            <asp:Label ID="lblpregunta17" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg17" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg17" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg17" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg17" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel18" runat="server">
        <asp:Image ID="Image18" runat="server" />
        <br />
            <asp:Label ID="lblpregunta18" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg18" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg18" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg18" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg18" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel19" runat="server">
            <asp:Image ID="Image19" runat="server" />
            <br />
            <asp:Label ID="lblpregunta19" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg19" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg19" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg19" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg19" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel20" runat="server">
        <asp:Image ID="Image20" runat="server" />
        <br />
            <asp:Label ID="lblpregunta20" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg20" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg20" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg20" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg20" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
