using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_12 : System.Web.UI.Page
    {
        public static string resppreg56, resppreg57, resppreg58, resppreg59, resppreg60;

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
            nva.JalarPreg56();

            Image56.ImageUrl = ("~/ImagenesDePreguntas/56.jpg");
            lblpregunta56.Text = nva.Preg1;
            rdbres1preg56.Text = nva.Op1;
            rdbres2preg56.Text = nva.Op2;
            rdbres3preg56.Text = nva.Op3;
            rdbres4preg56.Text = nva.Op4;
			resppreg56 = nva.Resp.TrimEnd();

            nva.JalarPreg57();

            Image57.ImageUrl = ("~/ImagenesDePreguntas/57.jpg");
            lblpregunta57.Text = nva.Preg1;
            rdbres1preg57.Text = nva.Op1;
            rdbres2preg57.Text = nva.Op2;
            rdbres3preg57.Text = nva.Op3;
            rdbres4preg57.Text = nva.Op4;
			resppreg57 = nva.Resp.TrimEnd();

            nva.JalarPreg58();

            Image58.ImageUrl = ("~/ImagenesDePreguntas/58.jpg");
            lblpregunta58.Text = nva.Preg1;
            rdbres1preg58.Text = nva.Op1;
            rdbres2preg58.Text = nva.Op2;
            rdbres3preg58.Text = nva.Op3;
            rdbres4preg58.Text = nva.Op4;
			resppreg58 = nva.Resp.TrimEnd();

            nva.JalarPreg59();

            Image59.ImageUrl = ("~/ImagenesDePreguntas/59.jpg");
            lblpregunta59.Text = nva.Preg1;
            rdbres1preg59.Text = nva.Op1;
            rdbres2preg59.Text = nva.Op2;
            rdbres3preg59.Text = nva.Op3;
            rdbres4preg59.Text = nva.Op4;
			resppreg59 = nva.Resp.TrimEnd();

            nva.JalarPreg60();

            Image60.ImageUrl = ("~/ImagenesDePreguntas/60.jpg");
            lblpregunta60.Text = nva.Preg1;
            rdbres1preg60.Text = nva.Op1;
            rdbres2preg60.Text = nva.Op2;
            rdbres3preg60.Text = nva.Op3;
            rdbres4preg60.Text = nva.Op4;
			resppreg60 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			guardado();
            Response.Redirect("Exam 13.aspx");   
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

            if (rdbres1preg56.Checked == true)
            {
                if (rdbres1preg56.Text.TrimEnd() == resppreg56)
                {
                    reg.Resp56 = "Correcta";
                }
                else
                {
                    reg.Resp56 = "Incorrecta";
                }
            }
            else if (rdbres2preg56.Checked == true)
            {
                if (rdbres2preg56.Text.TrimEnd() == resppreg56)
                {
                    reg.Resp56 = "Correcta";
                }
                else
                {
                    reg.Resp56 = "Incorrecta";
                }
            }
            else if (rdbres3preg56.Checked == true)
            {
                if (rdbres3preg56.Text.TrimEnd() == resppreg56)
                {
                    reg.Resp56 = "Correcta";
                }
                else
                {
                    reg.Resp56 = "Incorrecta";
                }
            }
            else if (rdbres4preg56.Checked == true)
            {
                if (rdbres4preg56.Text.TrimEnd() == resppreg56)
                {
                    reg.Resp56 = "Correcta";
                }
                else
                {
                    reg.Resp56 = "Incorrecta";
                }
            }


            if (rdbres1preg57.Checked == true)
            {
                if (rdbres1preg57.Text.TrimEnd() == resppreg57)
                {
                    reg.Resp57 = "Correcta";
                }
                else
                {
                    reg.Resp57 = "Incorrecta";
                }
            }
            else if (rdbres2preg57.Checked == true)
            {
                if (rdbres2preg57.Text.TrimEnd() == resppreg57)
                {
                    reg.Resp57 = "Correcta";
                }
                else
                {
                    reg.Resp57 = "Incorrecta";
                }
            }
            else if (rdbres3preg57.Checked == true)
            {
                if (rdbres3preg57.Text.TrimEnd() == resppreg57)
                {
                    reg.Resp57 = "Correcta";
                }
                else
                {
                    reg.Resp57 = "Incorrecta";
                }
            }
            else if (rdbres4preg57.Checked == true)
            {
                if (rdbres4preg57.Text.TrimEnd() == resppreg57)
                {
                    reg.Resp57 = "Correcta";
                }
                else
                {
                    reg.Resp57 = "Incorrecta";
                }
            }

            if (rdbres1preg58.Checked == true)
            {
                if (rdbres1preg58.Text.TrimEnd() == resppreg58)
                {
                    reg.Resp58 = "Correcta";
                }
                else
                {
                    reg.Resp58 = "Incorrecta";
                }
            }
            else if (rdbres2preg58.Checked == true)
            {
                if (rdbres2preg58.Text.TrimEnd() == resppreg58)
                {
                    reg.Resp58 = "Correcta";
                }
                else
                {
                    reg.Resp58 = "Incorrecta";
                }
            }
            else if (rdbres3preg58.Checked == true)
            {
                if (rdbres3preg58.Text.TrimEnd() == resppreg58)
                {
                    reg.Resp58 = "Correcta";
                }
                else
                {
                    reg.Resp58 = "Incorrecta";
                }
            }
            else if (rdbres4preg58.Checked == true)
            {
                if (rdbres4preg58.Text.TrimEnd() == resppreg58)
                {
                    reg.Resp58 = "Correcta";
                }
                else
                {
                    reg.Resp58 = "Incorrecta";
                }
            }

            if (rdbres1preg59.Checked == true)
            {
                if (rdbres1preg59.Text.TrimEnd() == resppreg59)
                {
                    reg.Resp59 = "Correcta";
                }
                else
                {
                    reg.Resp59 = "Incorrecta";
                }
            }
            else if (rdbres2preg59.Checked == true)
            {
                if (rdbres2preg59.Text.TrimEnd() == resppreg59)
                {
                    reg.Resp59 = "Correcta";
                }
                else
                {
                    reg.Resp59 = "Incorrecta";
                }
            }
            else if (rdbres3preg59.Checked == true)
            {
                if (rdbres3preg59.Text.TrimEnd() == resppreg59)
                {
                    reg.Resp59 = "Correcta";
                }
                else
                {
                    reg.Resp59 = "Incorrecta";
                }
            }
            else if (rdbres4preg59.Checked == true)
            {
                if (rdbres4preg59.Text.TrimEnd() == resppreg59)
                {
                    reg.Resp59 = "Correcta";
                }
                else
                {
                    reg.Resp59 = "Incorrecta";
                }
            }

            if (rdbres1preg60.Checked == true)
            {
                if (rdbres1preg60.Text.TrimEnd() == resppreg60)
                {
                    reg.Resp60 = "Correcta";
                }
                else
                {
                    reg.Resp60 = "Incorrecta";
                }
            }
            else if (rdbres2preg60.Checked == true)
            {
                if (rdbres2preg60.Text.TrimEnd() == resppreg60)
                {
                    reg.Resp60 = "Correcta";
                }
                else
                {
                    reg.Resp60 = "Incorrecta";
                }
            }
            else if (rdbres3preg60.Checked == true)
            {
                if (rdbres3preg60.Text.TrimEnd() == resppreg60)
                {
                    reg.Resp60 = "Correcta";
                }
                else
                {
                    reg.Resp60 = "Incorrecta";
                }
            }
            else if (rdbres4preg60.Checked == true)
            {
                if (rdbres4preg60.Text.TrimEnd() == resppreg60)
                {
                    reg.Resp60 = "Correcta";
                }
                else
                {
                    reg.Resp60 = "Incorrecta";
                }
            }
        }
    }
}