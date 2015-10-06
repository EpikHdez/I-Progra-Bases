<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Pagina1.aspx.cs" Inherits="ExamenWeb.FreePages.Pagina1" %>


<html>
<head><title>Time</title>
    <style type="text/css">
        #form1
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
            </asp:Timer>
            <asp:Label ID="lblHora" runat="server" Text="2"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text=":"></asp:Label>
            <asp:Label ID="lblMinutos" runat="server" Text="00"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text=":"></asp:Label>
            <asp:Label ID="lblSegundos" runat="server" Text="00"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
    </body>
</html>
