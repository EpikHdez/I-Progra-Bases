<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Pagina1.aspx.cs" Inherits="ExamenWeb.FreePages.Pagina1" %>


<html>
<head><title>Time</title>
    <style type="text/css">
        #form1
        {
            text-align: left;
        }
    </style>
    <script language="javascript" type="text/javascript">
        //CRONOMETRO
        //Autor: Iván Nieto Pérez
        //Este script y otros muchos pueden
        //descarse on-line de forma gratuita
        //en El Código: www.elcodigo.com
        var CronoID = null
        var CronoEjecutandose = false
        var decimas, segundos, minutos

        function DetenerCrono() {
            if (CronoEjecutandose)
                clearTimeout(CronoID)
            CronoEjecutandose = false
        }

        function InicializarCrono() {
            //inicializa contadores globales
            decimas = 0
            segundos = 0
            minutos = 0

            //pone a cero los marcadores
            document.crono.display.value = '00:00:0'
            document.crono.parcial.value = '00:00:0'
        }

        function MostrarCrono() {

            //incrementa el crono
            decimas++
            if (decimas > 9) {
                decimas = 0
                segundos++
                if (segundos > 59) {
                    segundos = 0
                    minutos++
                    if (minutos > 99) {
                        alert('Fin de la cuenta')
                        DetenerCrono()
                        return true
                    }
                }
            }

            //configura la salida
            var ValorCrono = ""
            ValorCrono = (minutos < 10) ? "0" + minutos : minutos
            ValorCrono += (segundos < 10) ? ":0" + segundos : ":" + segundos
            ValorCrono += ":" + decimas

            document.crono.display.value = ValorCrono

            CronoID = setTimeout("MostrarCrono()", 100)
            CronoEjecutandose = true
            return true
        }

        function IniciarCrono() {
            DetenerCrono()
            InicializarCrono()
            MostrarCrono()
        }

        function ObtenerParcial() {
            //obtiene cuenta parcial
            document.crono.parcial.value = document.crono.display.value
        }




</script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
            </asp:Timer>
            <asp:TextBox ID="txthoras" runat="server" Enabled="False" Width="25px">1</asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text=":"></asp:Label>
            <asp:TextBox ID="txtminutos" runat="server" Enabled="False" Width="25px">59</asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text=":"></asp:Label>
            <asp:TextBox ID="txtsegundos" runat="server" Enabled="False" Width="25px">59</asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
    </body>
</html>
