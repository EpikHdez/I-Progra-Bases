using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Páginas;
using ExamenWeb.Pages;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Calificar_examen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calificar();
            }
        }

        private void Calificar()
        {
            SQL_registro sql = new SQL_registro();

            int nota = 0;
            int nota_final = 0;

            if (sql.Resp1 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp2 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp3 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp4 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp5 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp6 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp7 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp8 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp9 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp10 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp11 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp12 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp13 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp14 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp15 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp16 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp17 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp18 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp19 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp20 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp21 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp22 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp23 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp24 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp25 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp26 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp27 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp28 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp29 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp30 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp31 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp32 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp33 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp34 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp35 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp36 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp37 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp38 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp39 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp40 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp41 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp42 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp43 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp44 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp45 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp46 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp47 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp48 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp49 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp50 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp51 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp52 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp53 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp54 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp55 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp56 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp57 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp58 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp59 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp60 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp61 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp62 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp63 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp64 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp65 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp66 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp67 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp68 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp69 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp70 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp71 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp72 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp73 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp74 == "Correcta")
            {
                nota += 1;
            }

            if (sql.Resp75 == "Correcta")
            {
                nota += 1;
            }

            nota_final = (nota * 100) / 75;

            lblnota.Text = nota_final.ToString();

            SQL_registro.Nota = nota_final;

            sql.Registro();
        }

        protected void btnsalir_Click(object sender, EventArgs e)
        {
            if (LogIn.tipo_usu == "03")
            {
                Response.Redirect("Menú estudiante.aspx");
            }
            else
            {
                Response.Redirect("Menú profesor.aspx");
            }
        }
    }
}
