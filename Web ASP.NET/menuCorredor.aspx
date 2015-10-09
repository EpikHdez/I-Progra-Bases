<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuCorredor.aspx.cs" Inherits="menuCorredor" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Alias" HeaderText="Alias" SortExpression="Alias" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" SortExpression="Contrasena" />
                <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [Corredores] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Corredores] ([Identificacion], [Nombre], [Alias], [Email], [Contrasena], [Genero], [FechaNacimiento], [Activo]) VALUES (@Identificacion, @Nombre, @Alias, @Email, @Contrasena, @Genero, @FechaNacimiento, @Activo)" ProviderName="<%$ ConnectionStrings:CampeonatosDBConnectionString1.ProviderName %>" SelectCommand="SELECT [ID], [Identificacion], [Nombre], [Alias], [Email], [Contrasena], [Genero], [FechaNacimiento], [Activo] FROM [Corredores]" UpdateCommand="UPDATE [Corredores] SET [Identificacion] = @Identificacion, [Nombre] = @Nombre, [Alias] = @Alias, [Email] = @Email, [Contrasena] = @Contrasena, [Genero] = @Genero, [FechaNacimiento] = @FechaNacimiento, [Activo] = @Activo WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Identificacion" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Alias" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Genero" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaNacimiento" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Identificacion" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Alias" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Genero" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaNacimiento" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:LinkButton ID="btnInsertarMenuCorredor" runat="server" Text="Insertar Corredor" OnClick="btnInsertarMenuCorredor_Click"></asp:LinkButton>
    </form>
</body>
</html>
