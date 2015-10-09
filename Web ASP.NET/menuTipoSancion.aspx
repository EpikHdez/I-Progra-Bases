<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuTipoSancion.aspx.cs" Inherits="menuTipoSancion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" InsertVisible="False" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="CASP_BorrarTipoSancion" InsertCommand="CASP_InsertarTipoSancion" SelectCommand="CASP_ObtenerTipoSancion" UpdateCommand="CASP_EditarTipoSancion" DeleteCommandType="StoredProcedure" InsertCommandType="StoredProcedure" SelectCommandType="StoredProcedure" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="pIDTipoSancion" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="pNombre" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="pID" Type="Int32" />
                <asp:Parameter Name="pNombre" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:LinkButton ID="btnAgregarTipoSancion" runat="server" Text="Agregar Tipo Sanción" OnClick="btnAgregarTipoSancion_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
