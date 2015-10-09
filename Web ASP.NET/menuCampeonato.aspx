<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuCampeonato.aspx.cs" Inherits="menuCampeonato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="FechaInicio" HeaderText="FechaInicio" SortExpression="FechaInicio" />
                <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" SortExpression="FechaFin" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [Campeonatos] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Campeonatos] ([Nombre], [FechaInicio], [FechaFin]) VALUES (@Nombre, @FechaInicio, @FechaFin)" SelectCommand="CASP_ObtenerCampeonatos" UpdateCommand="CASP_EditarCampeonato" UpdateCommandType="StoredProcedure" SelectCommandType="StoredProcedure">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaInicio" />
                <asp:Parameter DbType="Date" Name="FechaFin" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RETURN_VALUE" Type="Int32" Direction="ReturnValue" />
                <asp:Parameter Name="pID" Type="Int32" />
                <asp:Parameter Name="pNombre" Type="String" />
                <asp:Parameter DbType="Date" Name="pFechaInicio" />
                <asp:Parameter DbType="Date" Name="pFechaFin" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
        <p>



        </p>
        <asp:Label ID="Label1" runat="server" Text="No hay ningún elemento seleccionado" Visible="false"></asp:Label>
        <br />
        <asp:Button ID="btnMenuCarrerasCampeonato" runat="server" OnClick="btnMenuCarrerasCampeonato_Click" Text="Carreras del campeonato" />
        <asp:Button ID="btnMenuCorredoresCampeonato" runat="server" Text="Corredores del Campeonato" OnClick="btnMenuCorredoresCampeonato_Click"/>
        
    
    </div>
    </form>
</body>
</html>
