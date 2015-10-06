using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_14 : System.Web.UI.Page
    {
        public static bool resppreg66, resppreg67, resppreg68, resppreg69, resppreg70;

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
            nva.JalarPreg66();

            Image66.ImageUrl = ("~/ImagenesDePreguntas/66.jpg");
            lblpregunta66.Text = nva.Preg1;
            rdbres1preg66.Text = nva.Op1;
            rdbres2preg66.Text = nva.Op2;
            rdbres3preg66.Text = nva.Op3;
            rdbres4preg66.Text = nva.Op4;

            nva.JalarPreg67();

            Image67.ImageUrl = ("~/ImagenesDePreguntas/67.jpg");
            lblpregunta67.Text = nva.Preg1;
            rdbres1preg67.Text = nva.Op1;
            rdbres2preg67.Text = nva.Op2;
            rdbres3preg67.Text = nva.Op3;
            rdbres4preg67.Text = nva.Op4;

            nva.JalarPreg68();

            Image68.ImageUrl = ("~/ImagenesDePreguntas/68.jpg");
            lblpregunta68.Text = nva.Preg1;
            rdbres1preg68.Text = nva.Op1;
            rdbres2preg68.Text = nva.Op2;
            rdbres3preg68.Text = nva.Op3;
            rdbres4preg68.Text = nva.Op4;

            nva.JalarPreg69();

            Image69.ImageUrl = ("~/ImagenesDePreguntas/69.jpg");
            lblpregunta69.Text = nva.Preg1;
            rdbres1preg69.Text = nva.Op1;
            rdbres2preg69.Text = nva.Op2;
            rdbres3preg69.Text = nva.Op3;
            rdbres4preg69.Text = nva.Op4;

            nva.JalarPreg70();

            Image70.ImageUrl = ("~/ImagenesDePreguntas/70.jpg");
            lblpregunta70.Text = nva.Preg1;
            rdbres1preg70.Text = nva.Op1;
            rdbres2preg70.Text = nva.Op2;
            rdbres3preg70.Text = nva.Op3;
            rdbres4preg70.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 15.aspx");
            
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

            if (rdbres3preg66.Checked == true)
            {
                resppreg66 = true;
                SQL_registro.resp66 = "Correcta";
            }
            else
            {
                resppreg66 = false;
                SQL_registro.resp66 = "Incorrecta";
            }


            if (rdbres1preg67.Checked == true)
            {
                resppreg67 = true;
                SQL_registro.resp67 = "Correcta";
            }
            else
            {
                resppreg67 = false;
                SQL_registro.resp67 = "Incorrecta";
            }


            if (rdbres1preg68.Checked == true)
            {
                resppreg68 = true;
                SQL_registro.resp68 = "Correcta";
            }
            else
            {
                resppreg68 = false;
                SQL_registro.resp68 = "Incorrecta";
            }


            if (rdbres1preg69.Checked == true)
            {
                resppreg69 = true;
                SQL_registro.resp69 = "Correcta";
            }
            else
            {
                resppreg69 = false;
                SQL_registro.resp69 = "Incorrecta";
            }


            if (rdbres1preg70.Checked == true)
            {
                resppreg70 = true;
                SQL_registro.resp70 = "Correcta";
            }
            else
            {
                resppreg70 = false;
                SQL_registro.resp70 = "Incorrecta";
            }
        }
    }
}