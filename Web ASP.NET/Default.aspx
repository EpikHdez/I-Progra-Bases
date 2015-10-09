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
                            ImageUrl="~/Resources/acceder.png" OnClick="btningresar_Click"/> 
                    </td>
                </tr>
                 <tr>
                    <td colspan="3" width="120">
                        &nbsp;&nbsp;
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
    </form>
    </body>
</html>