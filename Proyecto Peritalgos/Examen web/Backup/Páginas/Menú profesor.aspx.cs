using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_web.Páginas
{
    public partial class Menú_profesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_preguntas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador de preguntas.aspx");
        }

        protected void btn_estudiantes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro estudiantes.aspx");
        }

        protected void btn_examen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Exam 1.aspx");
        }

        protected void btn_pruebarap_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prueba rápida1.aspx");
        }
    }
}