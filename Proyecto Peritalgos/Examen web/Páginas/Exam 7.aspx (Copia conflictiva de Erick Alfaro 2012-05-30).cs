using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_7 : System.Web.UI.Page
    {
        public static bool resppreg31, resppreg32, resppreg33, resppreg34, resppreg35;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar();
            }
        }

        protected void cargar()
        {
            SQL_conection nva = new SQL_conection();
            nva.JalarPreg31();

            Image31.ImageUrl = ("~/ImagenesDePreguntas/31.jpg");
            lblpregunta31.Text = nva.Preg1;
            rdbres1preg31.Text = nva.Op1;
            rdbres2preg31.Text = nva.Op2;
            rdbres3preg31.Text = nva.Op3;
            rdbres4preg31.Text = nva.Op4;

            nva.JalarPreg32();

            Image32.ImageUrl = ("~/ImagenesDePreguntas/32.jpg");
            lblpregunta32.Text = nva.Preg1;
            rdbres1preg32.Text = nva.Op1;
            rdbres2preg32.Text = nva.Op2;
            rdbres3preg32.Text = nva.Op3;
            rdbres4preg32.Text = nva.Op4;

            nva.JalarPreg33();

            Image33.ImageUrl = ("~/ImagenesDePreguntas/33.jpg");
            lblpregunta33.Text = nva.Preg1;
            rdbres1preg33.Text = nva.Op1;
            rdbres2preg33.Text = nva.Op2;
            rdbres3preg33.Text = nva.Op3;
            rdbres4preg33.Text = nva.Op4;

            nva.JalarPreg34();

            Image34.ImageUrl = ("~/ImagenesDePreguntas/34.jpg");
            lblpregunta34.Text = nva.Preg1;
            rdbres1preg34.Text = nva.Op1;
            rdbres2preg34.Text = nva.Op2;
            rdbres3preg34.Text = nva.Op3;
            rdbres4preg34.Text = nva.Op4;

            nva.JalarPreg35();

            Image35.ImageUrl = ("~/ImagenesDePreguntas/35.jpg");
            lblpregunta35.Text = nva.Preg1;
            rdbres1preg35.Text = nva.Op1;
            rdbres2preg35.Text = nva.Op2;
            rdbres3preg35.Text = nva.Op3;
            rdbres4preg35.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 8.aspx");
            
        }

        protected void Tiempo_Tick(object sender, EventArgs e)
        {
            Exam_1.seg = Exam_1.seg - 1;
            txtseg.Text = Exam_1.seg.ToString();

            if (Exam_1.seg == 0)
            {
                Exam_1.min = Exam_1.min - 1;
                txtmin.Text = Exam_1.min.ToString();
                Exam_1.seg = 59;
                txtseg.Text = Exam_1.seg.ToString();

                if (Exam_1.min == 0)
                {
                    Exam_1.min = 59;
                    txtmin.Text = Exam_1.min.ToString();

                    if (Exam_1.horas != 0)
                    {
                        Exam_1.horas = Exam_1.horas - 1;
                        txthoras.Text = Exam_1.horas.ToString();
                    }
                }
            }
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres4preg31.Checked == true)
            {
                resppreg31 = true;
                SQL_registro.resp31 = "Correcta";
            }
            else
            {
                resppreg31 = false;
                SQL_registro.resp31 = "Incorrecta";
            }


            if (rdbres2preg32.Checked == true)
            {
                resppreg32 = true;
                SQL_registro.resp32 = "Correcta";
            }
            else
            {
                resppreg32 = false;
                SQL_registro.resp32 = "Incorrecta";
            }


            if (rdbres3preg33.Checked == true)
            {
                resppreg33 = true;
                SQL_registro.resp33 = "Correcta";
            }
            else
            {
                resppreg33 = false;
                SQL_registro.resp33 = "Incorrecta";
            }


            if (rdbres2preg34.Checked == true)
            {
                resppreg34 = true;
                SQL_registro.resp34 = "Correcta";
            }
            else
            {
                resppreg34 = false;
                SQL_registro.resp34 = "Incorrecta";
            }


            if (rdbres1preg35.Checked == true)
            {
                resppreg35 = true;
                SQL_registro.resp35 = "Correcta";
            }
            else
            {
                resppreg35 = false;
                SQL_registro.resp35 = "Incorrecta";
            }
        }
    }
}