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
            if (!IsPostBack == true)
            {
                Calificar();
            }
        }

        private void Calificar()
        {
            SQL_registro sql = new SQL_registro();

            int nota = 0;
            int nota_final = 0;

            if (Exam_1.resppreg1 == true)
            {
                nota += 1;
            }

            if (Exam_1.resppreg2 == true)
            {
                nota += 1;
            }

            if (Exam_1.resppreg3 == true)
            {
                nota += 1;
            }

            if (Exam_1.resppreg4 == true)
            {
                nota += 1;
            }

            if (Exam_1.resppreg5 == true)
            {
                nota += 1;
            }

            if (Exam_2.resppreg6 == true)
            {
                nota += 1;
            }

            if (Exam_2.resppreg7 == true)
            {
                nota += 1;
            }

            if (Exam_2.resppreg8 == true)
            {
                nota += 1;
            }

            if (Exam_2.resppreg9 == true)
            {
                nota += 1;
            }

            if (Exam_2.resppreg10 == true)
            {
                nota += 1;
            }

            if (Exam_3.resppreg11 == true)
            {
                nota += 1;
            }

            if (Exam_3.resppreg12 == true)
            {
                nota += 1;
            }

            if (Exam_3.resppreg13 == true)
            {
                nota += 1;
            }

            if (Exam_3.resppreg14 == true)
            {
                nota += 1;
            }

            if (Exam_3.resppreg15 == true)
            {
                nota += 1;
            }

            if (Exam_4.resppreg16 == true)
            {
                nota += 1;
            }

            if (Exam_4.resppreg17 == true)
            {
                nota += 1;
            }

            if (Exam_4.resppreg18 == true)
            {
                nota += 1;
            }

            if (Exam_4.resppreg19 == true)
            {
                nota += 1;
            }

            if (Exam_4.resppreg20 == true)
            {
                nota += 1;
            }

            if (Exam_5.resppreg21 == true)
            {
                nota += 1;
            }

            if (Exam_5.resppreg22 == true)
            {
                nota += 1;
            }

            if (Exam_5.resppreg23 == true)
            {
                nota += 1;
            }

            if (Exam_5.resppreg24 == true)
            {
                nota += 1;
            }

            if (Exam_5.resppreg25 == true)
            {
                nota += 1;
            }

            if (Exam_6.resppreg26 == true)
            {
                nota += 1;
            }

            if (Exam_6.resppreg27 == true)
            {
                nota += 1;
            }

            if (Exam_6.resppreg28 == true)
            {
                nota += 1;
            }

            if (Exam_6.resppreg29 == true)
            {
                nota += 1;
            }

            if (Exam_6.resppreg30 == true)
            {
                nota += 1;
            }

            if (Exam_7.resppreg31 == true)
            {
                nota += 1;
            }

            if (Exam_7.resppreg32 == true)
            {
                nota += 1;
            }

            if (Exam_7.resppreg33 == true)
            {
                nota += 1;
            }

            if (Exam_7.resppreg34 == true)
            {
                nota += 1;
            }

            if (Exam_7.resppreg35 == true)
            {
                nota += 1;
            }

            if (Exam_8.resppreg36 == true)
            {
                nota += 1;
            }

            if (Exam_8.resppreg37 == true)
            {
                nota += 1;
            }

            if (Exam_8.resppreg38 == true)
            {
                nota += 1;
            }

            if (Exam_8.resppreg39 == true)
            {
                nota += 1;
            }

            if (Exam_8.resppreg40 == true)
            {
                nota += 1;
            }

            if (Exam_9.resppreg41 == true)
            {
                nota += 1;
            }

            if (Exam_9.resppreg42 == true)
            {
                nota += 1;
            }

            if (Exam_9.resppreg43 == true)
            {
                nota += 1;
            }

            if (Exam_9.resppreg44 == true)
            {
                nota += 1;
            }

            if (Exam_9.resppreg45 == true)
            {
                nota += 1;
            }

            if (Exam_10.resppreg46 == true)
            {
                nota += 1;
            }

            if (Exam_10.resppreg47 == true)
            {
                nota += 1;
            }

            if (Exam_10.resppreg48 == true)
            {
                nota += 1;
            }

            if (Exam_10.resppreg49 == true)
            {
                nota += 1;
            }

            if (Exam_10.resppreg50 == true)
            {
                nota += 1;
            }

            if (Exam_11.resppreg51 == true)
            {
                nota += 1;
            }

            if (Exam_11.resppreg52 == true)
            {
                nota += 1;
            }

            if (Exam_11.resppreg53 == true)
            {
                nota += 1;
            }

            if (Exam_11.resppreg54 == true)
            {
                nota += 1;
            }

            if (Exam_11.resppreg55 == true)
            {
                nota += 1;
            }

            if (Exam_12.resppreg56 == true)
            {
                nota += 1;
            }

            if (Exam_12.resppreg57 == true)
            {
                nota += 1;
            }

            if (Exam_12.resppreg58 == true)
            {
                nota += 1;
            }

            if (Exam_12.resppreg59 == true)
            {
                nota += 1;
            }

            if (Exam_12.resppreg60 == true)
            {
                nota += 1;
            }

            if (Exam_13.resppreg61 == true)
            {
                nota += 1;
            }

            if (Exam_13.resppreg62 == true)
            {
                nota += 1;
            }

            if (Exam_13.resppreg63 == true)
            {
                nota += 1;
            }

            if (Exam_13.resppreg64 == true)
            {
                nota += 1;
            }

            if (Exam_13.resppreg65 == true)
            {
                nota += 1;
            }

            if (Exam_14.resppreg66 == true)
            {
                nota += 1;
            }

            if (Exam_14.resppreg67 == true)
            {
                nota += 1;
            }

            if (Exam_14.resppreg68 == true)
            {
                nota += 1;
            }

            if (Exam_14.resppreg69 == true)
            {
                nota += 1;
            }

            if (Exam_14.resppreg70 == true)
            {
                nota += 1;
            }

            if (Exam_15.resppreg71 == true)
            {
                nota += 1;
            }

            if (Exam_15.resppreg72 == true)
            {
                nota += 1;
            }

            if (Exam_15.resppreg73 == true)
            {
                nota += 1;
            }

            if (Exam_15.resppreg74 == true)
            {
                nota += 1;
            }

            if (Exam_15.resppreg75 == true)
            {
                nota += 1;
            }

            nota_final = (nota * 100) / 75;

            lblnota.Text = nota_final.ToString();

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
