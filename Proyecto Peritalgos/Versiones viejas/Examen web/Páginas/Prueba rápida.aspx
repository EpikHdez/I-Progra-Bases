<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba rápida.aspx.cs" Inherits="Examen_web.Páginas.Prueba_rápida" %>

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
                <asp:TextBox ID="txthoras" runat="server" Enabled="False" Width="24px">1</asp:TextBox>
                :<asp:TextBox ID="txtmin" runat="server" Enabled="False" Width="24px">59</asp:TextBox>
                :<asp:TextBox ID="txtseg" runat="server" Enabled="False" Width="24px">59</asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblpregunta1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:CheckBox ID="chkres1preg1" runat="server" />
            <br />
            <asp:CheckBox ID="chkres2preg1" runat="server" />
            <br />
            <asp:CheckBox ID="chkres3preg1" runat="server" />
            <br />
            <asp:CheckBox ID="chkres4preg1" runat="server" />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="lblpregunta2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:CheckBox ID="chkres1preg2" runat="server" />
            <br />
            <asp:CheckBox ID="chkres2preg2" runat="server" />
            <br />
            <asp:CheckBox ID="chkres3preg2" runat="server" />
            <br />
            <asp:CheckBox ID="chkres4preg2" runat="server" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="lblpregunta3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:CheckBox ID="chkres1preg3" runat="server" />
            <br />
            <asp:CheckBox ID="chkres2preg3" runat="server" />
            <br />
            <asp:CheckBox ID="chkres3preg3" runat="server" />
            <br />
            <asp:CheckBox ID="chkres4preg3" runat="server" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server">
            <asp:Label ID="lblpregunta4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:CheckBox ID="chkres1preg4" runat="server" />
            <br />
            <asp:CheckBox ID="chkres2preg4" runat="server" />
            <br />
            <asp:CheckBox ID="chkres3preg4" runat="server" />
            <br />
            <asp:CheckBox ID="chkres4preg4" runat="server" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel5" runat="server">
            <asp:Label ID="lblpregunta5" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:CheckBox ID="chkres1preg5" runat="server" />
            <br />
            <asp:CheckBox ID="chkres2preg5" runat="server" />
            <br />
            <asp:CheckBox ID="chkres3preg5" runat="server" />
            <br />
            <asp:CheckBox ID="chkres4preg5" runat="server" />
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
