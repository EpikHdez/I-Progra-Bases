<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body class="main-container" background="../Resources/fondoazul.jpg">
    <form id="LogIn" runat="server">
    <div>
     <asp:Panel ID="Pnl_login" runat="server" Width="600px">
            <table  width="450" border="0"  align="center">
               
                <tr>
                    <td class="style4">
                        
                    </td>
                   <td colspan="3" width="120">
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td rowspan="5" class="style4" id="padlock"> 
                        &nbsp;
                        <img alt="" src="../Resources/login.png" class="imagen-login" />
                    </td>
                    
                     <td colspan="4" width="340">
                        &nbsp; 
                    </td>
                </tr>
               
                 <tr>
                    <td  colspan="2" align="right" class="style6" 
                        
                         style="color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-size: medium;">
                         <label for="<%=txtUserName.ClientID %>">Usuario:</label> 
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="txtUserName" runat="server" Width="207px" TabIndex="2" 
                             MaxLength="20"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right" class="style6" 
                        
                        style="color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-size: medium;">
                    <label for="<%=txtPassword.ClientID %>">Contraseña:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width="207px" 
                            TabIndex="3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" class="style7">
                        &nbsp;
                    </td>
                    <%--<td>
                    &nbsp;
                    </td>--%>
                    <td align="right" class="style8" id="go">
                        <asp:ImageButton ID="imgbtn" runat="server" ImageAlign="Middle" 
                            ImageUrl="~/Resources/acceder.png" />
                    </td>
                </tr>
                 <tr>
                    <td colspan="3" width="120">
                        &nbsp;&nbsp;
                        <asp:Button ID="btnagregar" runat="server"
                            Text="Agregar nuevo usuario" Height="31px" Width="306px" OnClick="btnagregar_Click" />
                    </td>
                </tr>
                 <tr>
                    <td colspan="4" width="620" align="center">
                        <asp:Label ID="lbl_error" runat="server" ForeColor="Red" 
                            Text="Contraseña incorrecta" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>      
    </div>
    <p>
        &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Alias" HeaderText="Alias" SortExpression="Alias" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CampeonatosDBConnectionString1 %>" DeleteCommand="DELETE FROM [Corredores] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Corredores] ([Identificacion], [Nombre], [Alias], [Email], [Genero], [FechaNacimiento], [Activo]) VALUES (@Identificacion, @Nombre, @Alias, @Email, @Genero, @FechaNacimiento, @Activo)" ProviderName="<%$ ConnectionStrings:CampeonatosDBConnectionString1.ProviderName %>" SelectCommand="SELECT [ID], [Identificacion], [Nombre], [Alias], [Email], [Genero], [FechaNacimiento], [Activo] FROM [Corredores]" UpdateCommand="UPDATE [Corredores] SET [Identificacion] = @Identificacion, [Nombre] = @Nombre, [Alias] = @Alias, [Email] = @Email, [Genero] = @Genero, [FechaNacimiento] = @FechaNacimiento, [Activo] = @Activo WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Identificacion" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Alias" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Genero" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaNacimiento" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Identificacion" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Alias" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Genero" Type="String" />
                <asp:Parameter DbType="Date" Name="FechaNacimiento" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
    </body>
</html>
