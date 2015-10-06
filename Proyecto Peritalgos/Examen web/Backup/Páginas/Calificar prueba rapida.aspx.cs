using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Calificar_prueba_rapida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            calificar();
        }

        public void calificar()
        {
            SQL_registro reg = new SQL_registro();

            int nota = 0;

            if (reg.Resp1 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp2 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp3 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp4 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp5 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp6 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp7 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp8 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp9 == "Correcta")
            {
                nota += 10;
            }

            if (reg.Resp10 == "Correcta")
            {
                nota += 10;
            }

            lbl_nota.Text = nota.ToString();
        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menú estudiante.aspx");
        }
    }
}