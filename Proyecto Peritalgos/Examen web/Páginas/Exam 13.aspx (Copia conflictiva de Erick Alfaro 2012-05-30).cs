using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_13 : System.Web.UI.Page
    {
        public static bool resppreg61, resppreg62, resppreg63, resppreg64, resppreg65;

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
            nva.JalarPreg61();

            Image61.ImageUrl = ("~/ImagenesDePreguntas/61.jpg");
            lblpregunta61.Text = nva.Preg1;
            rdbres1preg61.Text = nva.Op1;
            rdbres2preg61.Text = nva.Op2;
            rdbres3preg61.Text = nva.Op3;
            rdbres4preg61.Text = nva.Op4;

            nva.JalarPreg62();

            Image62.ImageUrl = ("~/ImagenesDePreguntas/62.jpg");
            lblpregunta62.Text = nva.Preg1;
            rdbres1preg62.Text = nva.Op1;
            rdbres2preg62.Text = nva.Op2;
            rdbres3preg62.Text = nva.Op3;
            rdbres4preg62.Text = nva.Op4;

            nva.JalarPreg63();

            Image63.ImageUrl = ("~/ImagenesDePreguntas/63.jpg");
            lblpregunta63.Text = nva.Preg1;
            rdbres1preg63.Text = nva.Op1;
            rdbres2preg63.Text = nva.Op2;
            rdbres3preg63.Text = nva.Op3;
            rdbres4preg63.Text = nva.Op4;

            nva.JalarPreg64();

            Image64.ImageUrl = ("~/ImagenesDePreguntas/64.jpg");
            lblpregunta64.Text = nva.Preg1;
            rdbres1preg64.Text = nva.Op1;
            rdbres2preg64.Text = nva.Op2;
            rdbres3preg64.Text = nva.Op3;
            rdbres4preg64.Text = nva.Op4;

            nva.JalarPreg65();

            Image65.ImageUrl = ("~/ImagenesDePreguntas/65.jpg");
            lblpregunta65.Text = nva.Preg1;
            rdbres1preg65.Text = nva.Op1;
            rdbres2preg65.Text = nva.Op2;
            rdbres3preg65.Text = nva.Op3;
            rdbres4preg65.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 14.aspx");
            
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

            if (rdbres1preg61.Checked == true)
            {
                resppreg61 = true;
                SQL_registro.resp61 = "Correcta";
            }
            else
            {
                resppreg61 = false;
                SQL_registro.resp61 = "Incorrecta";
            }


            if (rdbres4preg62.Checked == true)
            {
                resppreg62 = true;
                SQL_registro.resp62 = "Correcta";
            }
            else
            {
                resppreg62 = false;
                SQL_registro.resp62 = "Incorrecta";
            }


            if (rdbres2preg63.Checked == true)
            {
                resppreg63 = true;
                SQL_registro.resp63 = "Correcta";
            }
            else
            {
                resppreg63 = false;
                SQL_registro.resp63 = "Incorrecta";
            }


            if (rdbres1preg64.Checked == true)
            {
                resppreg64 = true;
                SQL_registro.resp64 = "Correcta";
            }
            else
            {
                resppreg64 = false;
                SQL_registro.resp64 = "Incorrecta";
            }


            if (rdbres2preg65.Checked == true)
            {
                resppreg65 = true;
                SQL_registro.resp65 = "Correcta";
            }
            else
            {
                resppreg65 = false;
                SQL_registro.resp65 = "Incorrecta";
            }
        }
    }
}