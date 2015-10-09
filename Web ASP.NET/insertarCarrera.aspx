<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarCarrera.aspx.cs" Inherits="insertarCarrera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h5>Descripción: <asp:textbox ID="txtDescripcionAgregarCarrera" runat="server"></asp:textbox></h5>
        <h5>Lugar Partida: <asp:TextBox ID="txtLugarPartidaAgregarCarrera" runat="server"></asp:TextBox></h5>
        <h5>Lugar Llegada: <asp:TextBox ID="txtlugarLlegadaAgregarCarrera" runat="server"></asp:TextBox></h5>
        <h5>Recorrido: <asp:TextBox ID="txtRecorridoAgregarCarrera" runat="server"></asp:TextBox></h5>
        <h5>Fecha: <asp:textbox ID="txtFechaAgregarCarrera" runat="server"></asp:textbox></h5>
        <h5>Hora: <asp:TextBox ID="txtHoraAgregarCarrera" runat="server"></asp:TextBox></h5>
        <h5>Costo: <asp:TextBox ID="txtCostoAgregarCarrera" runat="server"></asp:TextBox></h5>
        

        <asp:LinkButton ID="btnAgregarCarreraCampeonato" runat="server" Text="Agregar Carrera" OnClick="btnAgregarCarreraCampeonato_Click"></asp:LinkButton>
        <asp:Label ID="lbl_error" runat="server" Text="La inserción no fue satisfactoria" Visible="false"></asp:Label>
    
    </div>
    </form>
</body>
</html>
