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
        public static string resppreg51, resppreg52, resppreg53, resppreg54, resppreg55;

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
			resppreg51 = nva.Resp.TrimEnd();

            nva.JalarPreg52();

            Image52.ImageUrl = ("~/ImagenesDePreguntas/52.jpg");
            lblpregunta52.Text = nva.Preg1;
            rdbres1preg52.Text = nva.Op1;
            rdbres2preg52.Text = nva.Op2;
            rdbres3preg52.Text = nva.Op3;
            rdbres4preg52.Text = nva.Op4;
			resppreg52 = nva.Resp.TrimEnd();

            nva.JalarPreg53();

            Image53.ImageUrl = ("~/ImagenesDePreguntas/53.jpg");
            lblpregunta53.Text = nva.Preg1;
            rdbres1preg53.Text = nva.Op1;
            rdbres2preg53.Text = nva.Op2;
            rdbres3preg53.Text = nva.Op3;
            rdbres4preg53.Text = nva.Op4;
			resppreg53 = nva.Resp.TrimEnd();

            nva.JalarPreg54();

            Image54.ImageUrl = ("~/ImagenesDePreguntas/54.jpg");
            lblpregunta54.Text = nva.Preg1;
            rdbres1preg54.Text = nva.Op1;
            rdbres2preg54.Text = nva.Op2;
            rdbres3preg54.Text = nva.Op3;
            rdbres4preg54.Text = nva.Op4;
			resppreg54 = nva.Resp.TrimEnd();

            nva.JalarPreg55();

            Image55.ImageUrl = ("~/ImagenesDePreguntas/55.jpg");
            lblpregunta55.Text = nva.Preg1;
            rdbres1preg55.Text = nva.Op1;
            rdbres2preg55.Text = nva.Op2;
            rdbres3preg55.Text = nva.Op3;
            rdbres4preg55.Text = nva.Op4;
			resppreg55 = nva.Resp.TrimEnd();
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

            if (Exam_1.seg == 0 && Exam_1.min == 0 && Exam_1.horas == 0)
            {
                guardado();
                Response.Redirect("Calificar examen.aspx");
            }
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg51.Checked == true)
            {
                if (rdbres1preg51.Text.TrimEnd() == resppreg51)
                {
                    reg.Resp51 = "Correcta";
                }
                else
                {
                    reg.Resp51 = "Incorrecta";
                }
            }
            else if (rdbres2preg51.Checked == true)
            {
                if (rdbres2preg51.Text.TrimEnd() == resppreg51)
                {
                    reg.Resp51 = "Correcta";
                }
                else
                {
                    reg.Resp51 = "Incorrecta";
                }
            }
            else if (rdbres3preg51.Checked == true)
            {
                if (rdbres3preg51.Text.TrimEnd() == resppreg51)
                {
                    reg.Resp51 = "Correcta";
                }
                else
                {
                    reg.Resp51 = "Incorrecta";
                }
            }
            else if (rdbres4preg51.Checked == true)
            {
                if (rdbres4preg51.Text.TrimEnd() == resppreg51)
                {
                    reg.Resp51 = "Correcta";
                }
                else
                {
                    reg.Resp51 = "Incorrecta";
                }
            }


            if (rdbres1preg52.Checked == true)
            {
                if (rdbres1preg52.Text.TrimEnd() == resppreg52)
                {
                    reg.Resp52 = "Correcta";
                }
                else
                {
                    reg.Resp52 = "Incorrecta";
                }
            }
            else if (rdbres2preg52.Checked == true)
            {
                if (rdbres2preg52.Text.TrimEnd() == resppreg52)
                {
                    reg.Resp52 = "Correcta";
                }
                else
                {
                    reg.Resp52 = "Incorrecta";
                }
            }
            else if (rdbres3preg52.Checked == true)
            {
                if (rdbres3preg52.Text.TrimEnd() == resppreg52)
                {
                    reg.Resp52 = "Correcta";
                }
                else
                {
                    reg.Resp52 = "Incorrecta";
                }
            }
            else if (rdbres4preg52.Checked == true)
            {
                if (rdbres4preg52.Text.TrimEnd() == resppreg52)
                {
                    reg.Resp52 = "Correcta";
                }
                else
                {
                    reg.Resp52 = "Incorrecta";
                }
            }

            if (rdbres1preg53.Checked == true)
            {
                if (rdbres1preg53.Text.TrimEnd() == resppreg53)
                {
                    reg.Resp53 = "Correcta";
                }
                else
                {
                    reg.Resp53 = "Incorrecta";
                }
            }
            else if (rdbres2preg53.Checked == true)
            {
                if (rdbres2preg53.Text.TrimEnd() == resppreg53)
                {
                    reg.Resp53 = "Correcta";
                }
                else
                {
                    reg.Resp53 = "Incorrecta";
                }
            }
            else if (rdbres3preg53.Checked == true)
            {
                if (rdbres3preg53.Text.TrimEnd() == resppreg53)
                {
                    reg.Resp53 = "Correcta";
                }
                else
                {
                    reg.Resp53 = "Incorrecta";
                }
            }
            else if (rdbres4preg53.Checked == true)
            {
                if (rdbres4preg53.Text.TrimEnd() == resppreg53)
                {
                    reg.Resp53 = "Correcta";
                }
                else
                {
                    reg.Resp53 = "Incorrecta";
                }
            }

            if (rdbres1preg54.Checked == true)
            {
                if (rdbres1preg54.Text.TrimEnd() == resppreg54)
                {
                    reg.Resp54 = "Correcta";
                }
                else
                {
                    reg.Resp54 = "Incorrecta";
                }
            }
            else if (rdbres2preg54.Checked == true)
            {
                if (rdbres2preg54.Text.TrimEnd() == resppreg54)
                {
                    reg.Resp54 = "Correcta";
                }
                else
                {
                    reg.Resp54 = "Incorrecta";
                }
            }
            else if (rdbres3preg54.Checked == true)
            {
                if (rdbres3preg54.Text.TrimEnd() == resppreg54)
                {
                    reg.Resp54 = "Correcta";
                }
                else
                {
                    reg.Resp54 = "Incorrecta";
                }
            }
            else if (rdbres4preg54.Checked == true)
            {
                if (rdbres4preg54.Text.TrimEnd() == resppreg54)
                {
                    reg.Resp54 = "Correcta";
                }
                else
                {
                    reg.Resp54 = "Incorrecta";
                }
            }

            if (rdbres1preg55.Checked == true)
            {
                if (rdbres1preg55.Text.TrimEnd() == resppreg55)
                {
                    reg.Resp55 = "Correcta";
                }
                else
                {
                    reg.Resp55 = "Incorrecta";
                }
            }
            else if (rdbres2preg55.Checked == true)
            {
                if (rdbres2preg55.Text.TrimEnd() == resppreg55)
                {
                    reg.Resp55 = "Correcta";
                }
                else
                {
                    reg.Resp55 = "Incorrecta";
                }
            }
            else if (rdbres3preg55.Checked == true)
            {
                if (rdbres3preg55.Text.TrimEnd() == resppreg55)
                {
                    reg.Resp55 = "Correcta";
                }
                else
                {
                    reg.Resp55 = "Incorrecta";
                }
            }
            else if (rdbres4preg55.Checked == true)
            {
                if (rdbres4preg55.Text.TrimEnd() == resppreg55)
                {
                    reg.Resp55 = "Correcta";
                }
                else
                {
                    reg.Resp55 = "Incorrecta";
                }
            }
        }
    }
}