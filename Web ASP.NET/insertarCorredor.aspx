<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertarCorredor.aspx.cs" Inherits="insertarCorredor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h5>Identificación: <textarea id="identificacion"></textarea> </h5>
        <h5>Nombre: <textarea id="nombre"></textarea> </h5>
        <h5>Alias: <textarea id="alias"></textarea> </h5>
        <h5>Email: <textarea id="email"></textarea></h5>
        <h5>Genero: <select>
            <option value="Masculino">Masculino</option>
            <option value="Femenino">Femenino</option>
            </select>
        </h5>
        <button id="botonRegistro">Registrarse</button>
        
    </div>
    </form>
</body>
</html>
