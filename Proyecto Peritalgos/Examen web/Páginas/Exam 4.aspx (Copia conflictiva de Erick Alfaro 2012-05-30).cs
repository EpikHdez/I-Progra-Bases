using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_4 : System.Web.UI.Page
    {
        public static bool resppreg16, resppreg17, resppreg18, resppreg19, resppreg20;

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
            nva.JalarPreg16();

            Image16.ImageUrl = ("~/ImagenesDePreguntas/16.jpg");
            lblpregunta16.Text = nva.Preg1;
            rdbres1preg16.Text = nva.Op1;
            rdbres2preg16.Text = nva.Op2;
            rdbres3preg16.Text = nva.Op3;
            rdbres4preg16.Text = nva.Op4;

            nva.JalarPreg17();

            Image17.ImageUrl = ("~/ImagenesDePreguntas/17.jpg");
            lblpregunta17.Text = nva.Preg1;
            rdbres1preg17.Text = nva.Op1;
            rdbres2preg17.Text = nva.Op2;
            rdbres3preg17.Text = nva.Op3;
            rdbres4preg17.Text = nva.Op4;

            nva.JalarPreg18();

            Image18.ImageUrl = ("~/ImagenesDePreguntas/18.jpg");
            lblpregunta18.Text = nva.Preg1;
            rdbres1preg18.Text = nva.Op1;
            rdbres2preg18.Text = nva.Op2;
            rdbres3preg18.Text = nva.Op3;
            rdbres4preg18.Text = nva.Op4;

            nva.JalarPreg19();

            Image19.ImageUrl = ("~/ImagenesDePreguntas/19.jpg");
            lblpregunta19.Text = nva.Preg1;
            rdbres1preg19.Text = nva.Op1;
            rdbres2preg19.Text = nva.Op2;
            rdbres3preg19.Text = nva.Op3;
            rdbres4preg19.Text = nva.Op4;

            nva.JalarPreg20();

            Image20.ImageUrl = ("~/ImagenesDePreguntas/20.jpg");
            lblpregunta20.Text = nva.Preg1;
            rdbres1preg20.Text = nva.Op1;
            rdbres2preg20.Text = nva.Op2;
            rdbres3preg20.Text = nva.Op3;
            rdbres4preg20.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 5.aspx");
            
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

        public void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg16.Checked == true)
            {
                resppreg16 = true;
                SQL_registro.resp16 = "Correcta";
            }
            else
            {
                resppreg16 = false;
                SQL_registro.resp16 = "Incorrecta";
            }


            if (rdbres1preg17.Checked == true)
            {
                resppreg17 = true;
                SQL_registro.resp17 = "Correcta";
            }
            else
            {
                resppreg17 = false;
                SQL_registro.resp17 = "Incorrecta";
            }


            if (rdbres2preg18.Checked == true)
            {
                resppreg18 = true;
                SQL_registro.resp18 = "Correcta";
            }
            else
            {
                resppreg18 = false;
                SQL_registro.resp18 = "Incorrecta";
            }


            if (rdbres1preg19.Checked == true)
            {
                resppreg19 = true;
                SQL_registro.resp19 = "Correcta";
            }
            else
            {
                resppreg19 = false;
                SQL_registro.resp19 = "Incorrecta";
            }


            if (rdbres1preg20.Checked == true)
            {
                resppreg20 = true;
                SQL_registro.resp20 = "Correcta";
            }
            else
            {
                resppreg20 = false;
                SQL_registro.resp20 = "Incorrecta";
            }
        }
    }
}