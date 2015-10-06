<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 1.aspx.cs" Inherits="Examen_web.Páginas.Exam_1" %>

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
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblpregunta1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg1" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg1" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg1" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg1" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="lblpregunta2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg2" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg2" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg2" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg2" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="lblpregunta3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg3" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg3" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg3" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg3" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server">
            <asp:Label ID="lblpregunta4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg4" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg4" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg4" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg4" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel5" runat="server">
            <asp:Label ID="lblpregunta5" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg5" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg5" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg5" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg5" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
