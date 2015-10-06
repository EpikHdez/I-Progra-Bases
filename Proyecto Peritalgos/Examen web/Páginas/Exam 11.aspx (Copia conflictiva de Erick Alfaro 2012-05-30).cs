using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_11 : System.Web.UI.Page
    {
        public static bool resppreg51, resppreg52, resppreg53, resppreg54, resppreg55;

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
            nva.JalarPreg51();

            Image51.ImageUrl = ("~/ImagenesDePreguntas/51.jpg");
            lblpregunta51.Text = nva.Preg1;
            rdbres1preg51.Text = nva.Op1;
            rdbres2preg51.Text = nva.Op2;
            rdbres3preg51.Text = nva.Op3;
            rdbres4preg51.Text = nva.Op4;

            nva.JalarPreg52();

            Image52.ImageUrl = ("~/ImagenesDePreguntas/52.jpg");
            lblpregunta52.Text = nva.Preg1;
            rdbres1preg52.Text = nva.Op1;
            rdbres2preg52.Text = nva.Op2;
            rdbres3preg52.Text = nva.Op3;
            rdbres4preg52.Text = nva.Op4;

            nva.JalarPreg53();

            Image53.ImageUrl = ("~/ImagenesDePreguntas/53.jpg");
            lblpregunta53.Text = nva.Preg1;
            rdbres1preg53.Text = nva.Op1;
            rdbres2preg53.Text = nva.Op2;
            rdbres3preg53.Text = nva.Op3;
            rdbres4preg53.Text = nva.Op4;

            nva.JalarPreg54();

            Image54.ImageUrl = ("~/ImagenesDePreguntas/54.jpg");
            lblpregunta54.Text = nva.Preg1;
            rdbres1preg54.Text = nva.Op1;
            rdbres2preg54.Text = nva.Op2;
            rdbres3preg54.Text = nva.Op3;
            rdbres4preg54.Text = nva.Op4;

            nva.JalarPreg55();

            Image55.ImageUrl = ("~/ImagenesDePreguntas/55.jpg");
            lblpregunta55.Text = nva.Preg1;
            rdbres1preg55.Text = nva.Op1;
            rdbres2preg55.Text = nva.Op2;
            rdbres3preg55.Text = nva.Op3;
            rdbres4preg55.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 12.aspx");
            
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

            if (rdbres1preg51.Checked == true)
            {
                resppreg51 = true;
                SQL_registro.resp51 = "Correcta";
            }
            else
            {
                resppreg51 = false;
                SQL_registro.resp51 = "Incorrecta";
            }


            if (rdbres4preg52.Checked == true)
            {
                resppreg52 = true;
                SQL_registro.resp52 = "Correcta";
            }
            else
            {
                resppreg52 = false;
                SQL_registro.resp52 = "Incorrecta";
            }


            if (rdbres2preg53.Checked == true)
            {
                resppreg53 = true;
                SQL_registro.resp53 = "Correcta";
            }
            else
            {
                resppreg53 = false;
                SQL_registro.resp53 = "Incorrecta";
            }


            if (rdbres1preg54.Checked == true)
            {
                resppreg54 = true;
                SQL_registro.resp54 = "Correcta";
            }
            else
            {
                resppreg54 = false;
                SQL_registro.resp54 = "Incorrecta";
            }


            if (rdbres2preg55.Checked == true)
            {
                resppreg55 = true;
                SQL_registro.resp55 = "Correcta";
            }
            else
            {
                resppreg55 = false;
                SQL_registro.resp55 = "Incorrecta";
            }
        }
    }
}