using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenWeb.HelperClasses;

namespace ExamenWeb.Pages
{
    public partial class ComprobacionPR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void No_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void Si_Click(object sender, EventArgs e)
        {
            
            TimerData TD = new TimerData();
            TD.segundos = 59;
            TD.minutos = 59;
            TD.horas = 1;
            
            Response.Redirect("../FreePages/Pagina1.aspx");
        }
    }
}