<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuSancion.aspx.cs" Inherits="menuSancion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Puntos" HeaderText="Puntos" SortExpression="Puntos" />
                <asp:BoundField DataField="FKCarrera" HeaderText="FKCarrera" SortExpression="FKCarrera" />
                <asp:BoundField DataField="FKTipoSancion" HeaderText="FKTipoSancion" SortExpression="FKTipoSancion" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [Sanciones] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Sanciones] ([Puntos], [FKCarrera], [FKTipoSancion], [Activo]) VALUES (@Puntos, @FKCarrera, @FKTipoSancion, @Activo)" ProviderName="<%$ ConnectionStrings:CampeonatosDBConnectionString1.ProviderName %>" SelectCommand="SELECT [ID], [Puntos], [FKCarrera], [FKTipoSancion], [Activo] FROM [Sanciones]" UpdateCommand="UPDATE [Sanciones] SET [Puntos] = @Puntos, [FKCarrera] = @FKCarrera, [FKTipoSancion] = @FKTipoSancion, [Activo] = @Activo WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Puntos" Type="Int32" />
                <asp:Parameter Name="FKCarrera" Type="Int32" />
                <asp:Parameter Name="FKTipoSancion" Type="Int32" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Puntos" Type="Int32" />
                <asp:Parameter Name="FKCarrera" Type="Int32" />
                <asp:Parameter Name="FKTipoSancion" Type="Int32" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:LinkButton ID="btnAgregarSancion" runat="server" Text="Agregar Sancion" OnClick="btnAgregarSancion_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
