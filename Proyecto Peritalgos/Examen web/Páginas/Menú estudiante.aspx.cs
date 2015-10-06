using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_web.Páginas
{
    public partial class Menú_estudiante : System.Web.UI.Page
    {
        protected void btnpruebarapida_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prueba rápida1.aspx");
        }

        protected void btnexamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Exam 1.aspx");
        }
    }
}