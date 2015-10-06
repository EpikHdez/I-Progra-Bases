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
        public static string resppreg66, resppreg67, resppreg68, resppreg69, resppreg70;

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
			resppreg66 = nva.Resp.TrimEnd();

            nva.JalarPreg67();

            Image67.ImageUrl = ("~/ImagenesDePreguntas/67.jpg");
            lblpregunta67.Text = nva.Preg1;
            rdbres1preg67.Text = nva.Op1;
            rdbres2preg67.Text = nva.Op2;
            rdbres3preg67.Text = nva.Op3;
            rdbres4preg67.Text = nva.Op4;
			resppreg67 = nva.Resp.TrimEnd();

            nva.JalarPreg68();

            Image68.ImageUrl = ("~/ImagenesDePreguntas/68.jpg");
            lblpregunta68.Text = nva.Preg1;
            rdbres1preg68.Text = nva.Op1;
            rdbres2preg68.Text = nva.Op2;
            rdbres3preg68.Text = nva.Op3;
            rdbres4preg68.Text = nva.Op4;
			resppreg68 = nva.Resp.TrimEnd();

            nva.JalarPreg69();

            Image69.ImageUrl = ("~/ImagenesDePreguntas/69.jpg");
            lblpregunta69.Text = nva.Preg1;
            rdbres1preg69.Text = nva.Op1;
            rdbres2preg69.Text = nva.Op2;
            rdbres3preg69.Text = nva.Op3;
            rdbres4preg69.Text = nva.Op4;
			resppreg69 = nva.Resp.TrimEnd();

            nva.JalarPreg70();

            Image70.ImageUrl = ("~/ImagenesDePreguntas/70.jpg");
            lblpregunta70.Text = nva.Preg1;
            rdbres1preg70.Text = nva.Op1;
            rdbres2preg70.Text = nva.Op2;
            rdbres3preg70.Text = nva.Op3;
            rdbres4preg70.Text = nva.Op4;
			resppreg70 = nva.Resp.TrimEnd();
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

            if (Exam_1.seg == 0 && Exam_1.min == 0 && Exam_1.horas == 0)
            {
                guardado();
                Response.Redirect("Calificar examen.aspx");
            }
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg66.Checked == true)
            {
                if (rdbres1preg66.Text.TrimEnd() == resppreg66)
                {
                    reg.Resp66 = "Correcta";
                }
                else
                {
                    reg.Resp66 = "Incorrecta";
                }
            }
            else if (rdbres2preg66.Checked == true)
            {
                if (rdbres2preg66.Text.TrimEnd() == resppreg66)
                {
                    reg.Resp66 = "Correcta";
                }
                else
                {
                    reg.Resp66 = "Incorrecta";
                }
            }
            else if (rdbres3preg66.Checked == true)
            {
                if (rdbres3preg66.Text.TrimEnd() == resppreg66)
                {
                    reg.Resp66 = "Correcta";
                }
                else
                {
                    reg.Resp66 = "Incorrecta";
                }
            }
            else if (rdbres4preg66.Checked == true)
            {
                if (rdbres4preg66.Text.TrimEnd() == resppreg66)
                {
                    reg.Resp66 = "Correcta";
                }
                else
                {
                    reg.Resp66 = "Incorrecta";
                }
            }


            if (rdbres1preg67.Checked == true)
            {
                if (rdbres1preg67.Text.TrimEnd() == resppreg67)
                {
                    reg.Resp67 = "Correcta";
                }
                else
                {
                    reg.Resp67 = "Incorrecta";
                }
            }
            else if (rdbres2preg67.Checked == true)
            {
                if (rdbres2preg67.Text.TrimEnd() == resppreg67)
                {
                    reg.Resp67 = "Correcta";
                }
                else
                {
                    reg.Resp67 = "Incorrecta";
                }
            }
            else if (rdbres3preg67.Checked == true)
            {
                if (rdbres3preg67.Text.TrimEnd() == resppreg67)
                {
                    reg.Resp67 = "Correcta";
                }
                else
                {
                    reg.Resp67 = "Incorrecta";
                }
            }
            else if (rdbres4preg67.Checked == true)
            {
                if (rdbres4preg67.Text.TrimEnd() == resppreg67)
                {
                    reg.Resp67 = "Correcta";
                }
                else
                {
                    reg.Resp67 = "Incorrecta";
                }
            }

            if (rdbres1preg68.Checked == true)
            {
                if (rdbres1preg68.Text.TrimEnd() == resppreg68)
                {
                    reg.Resp68 = "Correcta";
                }
                else
                {
                    reg.Resp68 = "Incorrecta";
                }
            }
            else if (rdbres2preg68.Checked == true)
            {
                if (rdbres2preg68.Text.TrimEnd() == resppreg68)
                {
                    reg.Resp68 = "Correcta";
                }
                else
                {
                    reg.Resp68 = "Incorrecta";
                }
            }
            else if (rdbres3preg68.Checked == true)
            {
                if (rdbres3preg68.Text.TrimEnd() == resppreg68)
                {
                    reg.Resp68 = "Correcta";
                }
                else
                {
                    reg.Resp68 = "Incorrecta";
                }
            }
            else if (rdbres4preg68.Checked == true)
            {
                if (rdbres4preg68.Text.TrimEnd() == resppreg68)
                {
                    reg.Resp68 = "Correcta";
                }
                else
                {
                    reg.Resp68 = "Incorrecta";
                }
            }

            if (rdbres1preg69.Checked == true)
            {
                if (rdbres1preg69.Text.TrimEnd() == resppreg69)
                {
                    reg.Resp69 = "Correcta";
                }
                else
                {
                    reg.Resp69 = "Incorrecta";
                }
            }
            else if (rdbres2preg69.Checked == true)
            {
                if (rdbres2preg69.Text.TrimEnd() == resppreg69)
                {
                    reg.Resp69 = "Correcta";
                }
                else
                {
                    reg.Resp69 = "Incorrecta";
                }
            }
            else if (rdbres3preg69.Checked == true)
            {
                if (rdbres3preg69.Text.TrimEnd() == resppreg69)
                {
                    reg.Resp69 = "Correcta";
                }
                else
                {
                    reg.Resp69 = "Incorrecta";
                }
            }
            else if (rdbres4preg69.Checked == true)
            {
                if (rdbres4preg69.Text.TrimEnd() == resppreg69)
                {
                    reg.Resp69 = "Correcta";
                }
                else
                {
                    reg.Resp69 = "Incorrecta";
                }
            }

            if (rdbres1preg70.Checked == true)
            {
                if (rdbres1preg70.Text.TrimEnd() == resppreg70)
                {
                    reg.Resp70 = "Correcta";
                }
                else
                {
                    reg.Resp70 = "Incorrecta";
                }
            }
            else if (rdbres2preg70.Checked == true)
            {
                if (rdbres2preg70.Text.TrimEnd() == resppreg70)
                {
                    reg.Resp70 = "Correcta";
                }
                else
                {
                    reg.Resp70 = "Incorrecta";
                }
            }
            else if (rdbres3preg70.Checked == true)
            {
                if (rdbres3preg70.Text.TrimEnd() == resppreg70)
                {
                    reg.Resp70 = "Correcta";
                }
                else
                {
                    reg.Resp70 = "Incorrecta";
                }
            }
            else if (rdbres4preg70.Checked == true)
            {
                if (rdbres4preg70.Text.TrimEnd() == resppreg70)
                {
                    reg.Resp70 = "Correcta";
                }
                else
                {
                    reg.Resp70 = "Incorrecta";
                }
            }
        }
    }
}