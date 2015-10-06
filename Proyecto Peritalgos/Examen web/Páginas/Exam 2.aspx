<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 2.aspx.cs" Inherits="Examen_web.Páginas.Exam_2" %>

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
        <asp:Panel ID="Panel6" runat="server">
            <asp:Label ID="lblpregunta6" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg6" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg6" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg6" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg6" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel7" runat="server">
            <asp:Label ID="lblpregunta7" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg7" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg7" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg7" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg7" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel8" runat="server">
            <asp:Label ID="lblpregunta8" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg8" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg8" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg8" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg8" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel9" runat="server">
            <asp:Label ID="lblpregunta9" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg9" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg9" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg9" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg9" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel10" runat="server">
            <asp:Label ID="lblpregunta10" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg10" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg10" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg10" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg10" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
