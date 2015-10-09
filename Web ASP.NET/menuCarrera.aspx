<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuCarrera.aspx.cs" Inherits="menuCarrera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" InsertVisible="False" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="LugarPartida" HeaderText="LugarPartida" SortExpression="LugarPartida" />
                <asp:BoundField DataField="LugarLLegada" HeaderText="LugarLLegada" SortExpression="LugarLLegada" />
                <asp:BoundField DataField="Recorrido" HeaderText="Recorrido" SortExpression="Recorrido" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="Hora" HeaderText="Hora" SortExpression="Hora" />
                <asp:BoundField DataField="Costo" HeaderText="Costo" SortExpression="Costo" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="CASP_BorrarCarrera" InsertCommand="CASP_InsertarCarrera" SelectCommand="CASP_ObtenerCarrerasPorCampeonato" UpdateCommand="CASP_EditarCarrera" DeleteCommandType="StoredProcedure" InsertCommandType="StoredProcedure" SelectCommandType="StoredProcedure" UpdateCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="pIDCarrera" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="pDescripcion" Type="String" />
                <asp:Parameter Name="pLugarPartida" Type="String" />
                <asp:Parameter Name="pLugarLlegada" Type="String" />
                <asp:Parameter Name="pRecorrido" Type="String" />
                <asp:Parameter DbType="Date" Name="pFecha" />
                <asp:Parameter DbType="Time" Name="pHora" />
                <asp:Parameter Name="pCosto" Type="Int32" />
                <asp:Parameter Name="pCampeonato" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:SessionParameter DefaultValue="" Name="pIDCampeonato" SessionField="campeonatoActual" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="pID" Type="Int32" />
                <asp:Parameter Name="pDescripcion" Type="String" />
                <asp:Parameter Name="pLugarPartida" Type="String" />
                <asp:Parameter Name="pLugarLlegada" Type="String" />
                <asp:Parameter Name="pRecorrido" Type="Double" />
                <asp:Parameter DbType="Date" Name="pFecha" />
                <asp:Parameter DbType="Time" Name="pHora" />
                <asp:Parameter Name="pCosto" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:LinkButton ID="btnInsertarCarrera" runat="server" Text="Insertar Carrera" OnClick="btnInsertarCarrera_Click"></asp:LinkButton>
        <br />
        <asp:LinkButton ID="btnInsertarSancion" runat="server" Text="Insertar Sanción" OnClick="btnInsertarSancion_Click" ></asp:LinkButton>
    </form>
</body>
</html>
