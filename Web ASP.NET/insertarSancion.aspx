<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarSancion.aspx.cs" Inherits="insertarSancion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h5>Puntos: <asp:TextBox ID="txtPuntosAgregarSancion" runat="server"></asp:TextBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [TipoSancion] WHERE [ID] = @ID" InsertCommand="INSERT INTO [TipoSancion] ([Nombre], [Activo]) VALUES (@Nombre, @Activo)" ProviderName="<%$ ConnectionStrings:CampeonatosDBConnectionString1.ProviderName %>" SelectCommand="SELECT [ID], [Nombre], [Activo] FROM [TipoSancion]" UpdateCommand="UPDATE [TipoSancion] SET [Nombre] = @Nombre, [Activo] = @Activo WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Nombre" Type="String" />
                    <asp:Parameter Name="Activo" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Nombre" Type="String" />
                    <asp:Parameter Name="Activo" Type="Boolean" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </h5>
        <h5>Tipo Sancion: <asp:TextBox ID="txtSancionAgregarSancion" runat="server"></asp:TextBox></h5>
        <h5>Tipo movimiento sanción: <asp:TextBox ID="txtTipoMovimientoSancion" runat="server"></asp:TextBox></h5>
        <h5>Número de corredor: <asp:TextBox ID="txtNumeroCorredor" runat="server"></asp:TextBox></h5>

        <asp:LinkButton ID="btnAgregarSancion" runat="server" Text="Agregar Sanción" OnClick="btnAgregarSancion_Click"></asp:LinkButton>
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" EmptyDataText="No hay registros de datos para mostrar.">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [TipoMovimientoSancion] WHERE [ID] = @ID" InsertCommand="INSERT INTO [TipoMovimientoSancion] ([Nombre], [Activo]) VALUES (@Nombre, @Activo)" ProviderName="<%$ ConnectionStrings:CampeonatosDBConnectionString1.ProviderName %>" SelectCommand="SELECT [ID], [Nombre], [Activo] FROM [TipoMovimientoSancion]" UpdateCommand="UPDATE [TipoMovimientoSancion] SET [Nombre] = @Nombre, [Activo] = @Activo WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        
    </form>
</body>
</html>
