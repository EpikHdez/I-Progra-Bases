<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="ExamenWeb.FreePages.Pagina1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
      <script type="text/javascript"> //funcion del timer
          $(document).ready(function TimerFuera() {
              if ($("#txthoras").text == 0 && $("#txtminutos").text == 0 && $("#txtsegundos").text == 0) {
                  alert("Esto se acabo!");
                  window.open("../Pages/Inicio.aspx");
              }
          });
            </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
            </asp:Timer>
            <asp:TextBox ID="txthoras" runat="server" Width="22px">0</asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text=":"></asp:Label>
            <asp:TextBox ID="txtminutos" runat="server" Width="24px">0</asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text=":"></asp:Label>
            <asp:TextBox ID="txtsegundos" runat="server" Width="24px">59</asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
