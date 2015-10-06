using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenWeb.Pages;

namespace ExamenWeb.Pages
{
    public partial class LogIn : System.Web.UI.Page
    {
       
        protected void imgbtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Menú estudiante.aspx");
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar nuevo usuario.aspx");
        }
    }
}