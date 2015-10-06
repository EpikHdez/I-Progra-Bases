<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 15.aspx.cs" Inherits="Examen_web.Páginas.Exam_15" %>

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
        <asp:Panel ID="Panel71" runat="server">
        <asp:Image ID="Image71" runat="server" />
        <br />
            <asp:Label ID="lblpregunta71" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg71" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg71" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg71" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg71" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel72" runat="server">
        <asp:Image ID="Image72" runat="server" />
        <br />
            <asp:Label ID="lblpregunta72" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg72" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg72" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg72" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg72" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel73" runat="server">
        <asp:Image ID="Image73" runat="server" />
        <br />
            <asp:Label ID="lblpregunta73" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg73" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg73" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg73" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg73" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel74" runat="server">
            <asp:Image ID="Image74" runat="server" />
            <br />
            <asp:Label ID="lblpregunta74" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg74" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg74" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg74" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg74" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel75" runat="server">
        <asp:Image ID="Image75" runat="server" />
        <br />
            <asp:Label ID="lblpregunta75" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg75" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg75" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg75" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg75" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Calificar" />
        <br />
    
    </div>
    </form>
</body>
</html>
