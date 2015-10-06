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
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="FechaInicio" HeaderText="FechaInicio" SortExpression="FechaInicio" />
                <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" SortExpression="FechaFin" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [Campeonatos] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Campeonatos] ([Nombre], [FechaInicio], [FechaFin]) VALUES (@Nombre, @FechaInicio, @FechaFin)" ProviderName="<%$ ConnectionStrings:CampeonatosDBConnectionString1.ProviderName %>" SelectCommand="SELECT [ID], [Nombre], [FechaInicio], [FechaFin] FROM [Campeonatos]" UpdateCommand="UPDATE [Campeonatos] SET [Nombre] = @Nombre, [FechaInicio] = @FechaInicio, [FechaFin] = @FechaFin WHERE [ID] = @ID" OnSelecting="SqlDataSource1_Selecting">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaInicio" />
                <asp:Parameter DbType="Date" Name="FechaFin" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaInicio" />
                <asp:Parameter DbType="Date" Name="FechaFin" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
