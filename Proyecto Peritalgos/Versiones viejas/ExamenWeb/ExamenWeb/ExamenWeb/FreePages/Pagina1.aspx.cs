using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenWeb.HelperClasses;

namespace ExamenWeb.FreePages
{
    public partial class Pagina1 : System.Web.UI.Page
    {

        TimerData TD = new TimerData();

        int segundos, minutos, horas;

        protected void Page_Load(object sender, EventArgs e)
        {
            segundos = int.Parse(txtsegundos.Text);
            minutos = int.Parse(txtminutos.Text);
            horas = int.Parse(txthoras.Text);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            segundos = segundos - 1;
            txtsegundos.Text = segundos.ToString();

            if (segundos == 0)
            {
                segundos = 59;
                txtsegundos.Text = segundos.ToString();
                minutos = minutos - 1;
                txtminutos.Text = minutos.ToString();

                if (minutos == 0)
                {
                    minutos = 59;
                    txtminutos.Text = minutos.ToString();
                    horas = horas - 1;
                    txthoras.Text = horas.ToString();

                    if (horas == 0)
                    {
                        minutos = 59;
                        txtminutos.Text = minutos.ToString();
                    }
                }
            }

            TD.segundos = segundos;
            TD.minutos = minutos;
            TD.horas = horas;
        }
    }
}