<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuTipoMovimientoSancion.aspx.cs" Inherits="menuTipoMovimientoSancion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" InsertVisible="False" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="CASP_BorrarTipoMovimientoSancion" InsertCommand="CASP_InsertarTipoMovimientoSancion" SelectCommand="CASP_ObtenerTipoMovimientoSancion" UpdateCommand="CASP_EditaTipoMovimientoSancion" DeleteCommandType="StoredProcedure" InsertCommandType="StoredProcedure" SelectCommandType="StoredProcedure" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="pIDTipoMovimientoSancion" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="pNombre" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="pID" Type="Int32" />
                <asp:Parameter Name="pNombre" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:LinkButton ID="btnTipoMovimientoSancion" runat="server" Text="Agregar Tipo Movimiento Sanción" OnClick="btnTipoMovimientoSancion_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
