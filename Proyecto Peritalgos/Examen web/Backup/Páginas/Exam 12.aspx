<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 12.aspx.cs" Inherits="Examen_web.Páginas.Exam_12" %>

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
        <asp:Panel ID="Panel56" runat="server">
        <asp:Image ID="Image56" runat="server" />
        <br />
            <asp:Label ID="lblpregunta56" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg56" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg56" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg56" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg56" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel57" runat="server">
        <asp:Image ID="Image57" runat="server" />
        <br />
            <asp:Label ID="lblpregunta57" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg57" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg57" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg57" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg57" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel58" runat="server">
        <asp:Image ID="Image58" runat="server" />
        <br />
            <asp:Label ID="lblpregunta58" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg58" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg58" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg58" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg58" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel59" runat="server">
            <asp:Image ID="Image59" runat="server" />
            <br />
            <asp:Label ID="lblpregunta59" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg59" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg59" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg59" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg59" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel60" runat="server">
        <asp:Image ID="Image60" runat="server" />
        <br />
            <asp:Label ID="lblpregunta60" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg60" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg60" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg60" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg60" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
