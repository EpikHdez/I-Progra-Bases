<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuTipoMovimientoPuntos.aspx.cs" Inherits="menuTipoMovimientoPuntos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" InsertVisible="False" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="CASP_BorrarTipoMovimientoPuntos" InsertCommand="CASP_InsertarTipoMovimientoPuntos" SelectCommand="CASP_ObtenerTipoMovimientoPuntos" UpdateCommand="CASP_EditaTipoMovimientoPuntos" DeleteCommandType="StoredProcedure" InsertCommandType="StoredProcedure" SelectCommandType="StoredProcedure" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="pIDTipoMovimientoPuntos" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="pNombre" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="pID" Type="Int32" />
                <asp:Parameter Name="pNombre" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:LinkButton ID="btnAgregarTipoMovimientoPuntos" runat="server" Text="Agregar Tipo Movimiento Puntos" OnClick="btnAgregarTipoMovimientoPuntos_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
