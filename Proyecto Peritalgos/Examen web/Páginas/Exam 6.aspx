<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam 6.aspx.cs" Inherits="Examen_web.Páginas.Exam_6" %>

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
        <asp:Panel ID="Panel26" runat="server">
        <asp:Image ID="Image26" runat="server" />
        <br />
            <asp:Label ID="lblpregunta26" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg26" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres2preg26" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres3preg26" runat="server" GroupName="preg1" />
            <br />
            <asp:RadioButton ID="rdbres4preg26" runat="server" GroupName="preg1" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel27" runat="server">
        <asp:Image ID="Image27" runat="server" />
        <br />
            <asp:Label ID="lblpregunta27" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg27" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres2preg27" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres3preg27" runat="server" GroupName="preg2" />
            <br />
            <asp:RadioButton ID="rdbres4preg27" runat="server" GroupName="preg2" />
        </asp:Panel>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel28" runat="server">
        <asp:Image ID="Image28" runat="server" />
        <br />
            <asp:Label ID="lblpregunta28" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg28" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres2preg28" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres3preg28" runat="server" GroupName="preg3" />
            <br />
            <asp:RadioButton ID="rdbres4preg28" runat="server" GroupName="preg3" />
        </asp:Panel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Panel ID="Panel29" runat="server">
            <asp:Image ID="Image29" runat="server" />
            <br />
            <asp:Label ID="lblpregunta29" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg29" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres2preg29" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres3preg29" runat="server" GroupName="preg4" />
            <br />
            <asp:RadioButton ID="rdbres4preg29" runat="server" GroupName="preg4" />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="Panel30" runat="server">
        <asp:Image ID="Image30" runat="server" />
        <br />
            <asp:Label ID="lblpregunta30" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbres1preg30" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres2preg30" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres3preg30" runat="server" GroupName="preg5" />
            <br />
            <asp:RadioButton ID="rdbres4preg30" runat="server" GroupName="preg5" />
        </asp:Panel>
        <br />
        <asp:Button ID="btn_siguiente" runat="server" onclick="Button1_Click" 
            Text="Siguiente" />
        <br />
    
    </div>
    </form>
</body>
</html>
