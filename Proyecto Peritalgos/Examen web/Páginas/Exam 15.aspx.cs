using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_15 : System.Web.UI.Page
    {
        public static string resppreg71, resppreg72, resppreg73, resppreg74, resppreg75;

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
            nva.JalarPreg71();

            Image71.ImageUrl = ("~/ImagenesDePreguntas/71.jpg");
            lblpregunta71.Text = nva.Preg1;
            rdbres1preg71.Text = nva.Op1;
            rdbres2preg71.Text = nva.Op2;
            rdbres3preg71.Text = nva.Op3;
            rdbres4preg71.Text = nva.Op4;
            resppreg71 = nva.Resp.TrimEnd();

            nva.JalarPreg72();

            Image72.ImageUrl = ("~/ImagenesDePreguntas/72.jpg");
            lblpregunta72.Text = nva.Preg1;
            rdbres1preg72.Text = nva.Op1;
            rdbres2preg72.Text = nva.Op2;
            rdbres3preg72.Text = nva.Op3;
            rdbres4preg72.Text = nva.Op4;
            resppreg72 = nva.Resp.TrimEnd();

            nva.JalarPreg73();

            Image73.ImageUrl = ("~/ImagenesDePreguntas/73.jpg");
            lblpregunta73.Text = nva.Preg1;
            rdbres1preg73.Text = nva.Op1;
            rdbres2preg73.Text = nva.Op2;
            rdbres3preg73.Text = nva.Op3;
            rdbres4preg73.Text = nva.Op4;
            resppreg73 = nva.Resp.TrimEnd();

            nva.JalarPreg74();

            Image74.ImageUrl = ("~/ImagenesDePreguntas/74.jpg");
            lblpregunta74.Text = nva.Preg1;
            rdbres1preg74.Text = nva.Op1;
            rdbres2preg74.Text = nva.Op2;
            rdbres3preg74.Text = nva.Op3;
            rdbres4preg74.Text = nva.Op4;
            resppreg74 = nva.Resp.TrimEnd();

            nva.JalarPreg75();

            Image75.ImageUrl = ("~/ImagenesDePreguntas/75.jpg");
            lblpregunta75.Text = nva.Preg1;
            rdbres1preg75.Text = nva.Op1;
            rdbres2preg75.Text = nva.Op2;
            rdbres3preg75.Text = nva.Op3;
            rdbres4preg75.Text = nva.Op4;
            resppreg75 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Calificar examen.aspx");
            guardado();
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
                Response.Redirect("Calificar examen.aspx");
				guardado();
            }
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg71.Checked == true)
            {
                if (rdbres1preg71.Text.TrimEnd() == resppreg71)
                {
                    reg.Resp71 = "Correcta";
                }
                else
                {
                    reg.Resp71 = "Incorrecta";
                }
            }
            else if (rdbres2preg71.Checked == true)
            {
                if (rdbres2preg71.Text.TrimEnd() == resppreg71)
                {
                    reg.Resp71 = "Correcta";
                }
                else
                {
                    reg.Resp71 = "Incorrecta";
                }
            }
            else if (rdbres3preg71.Checked == true)
            {
                if (rdbres3preg71.Text.TrimEnd() == resppreg71)
                {
                    reg.Resp71 = "Correcta";
                }
                else
                {
                    reg.Resp71 = "Incorrecta";
                }
            }
            else if (rdbres4preg71.Checked == true)
            {
                if (rdbres4preg71.Text.TrimEnd() == resppreg71)
                {
                    reg.Resp71 = "Correcta";
                }
                else
                {
                    reg.Resp71 = "Incorrecta";
                }
            }


            if (rdbres1preg72.Checked == true)
            {
                if (rdbres1preg72.Text.TrimEnd() == resppreg72)
                {
                    reg.Resp72 = "Correcta";
                }
                else
                {
                    reg.Resp72 = "Incorrecta";
                }
            }
            else if (rdbres2preg72.Checked == true)
            {
                if (rdbres2preg72.Text.TrimEnd() == resppreg72)
                {
                    reg.Resp72 = "Correcta";
                }
                else
                {
                    reg.Resp72 = "Incorrecta";
                }
            }
            else if (rdbres3preg72.Checked == true)
            {
                if (rdbres3preg72.Text.TrimEnd() == resppreg72)
                {
                    reg.Resp72 = "Correcta";
                }
                else
                {
                    reg.Resp72 = "Incorrecta";
                }
            }
            else if (rdbres4preg72.Checked == true)
            {
                if (rdbres4preg72.Text.TrimEnd() == resppreg72)
                {
                    reg.Resp72 = "Correcta";
                }
                else
                {
                    reg.Resp72 = "Incorrecta";
                }
            }

            if (rdbres1preg73.Checked == true)
            {
                if (rdbres1preg73.Text.TrimEnd() == resppreg73)
                {
                    reg.Resp73 = "Correcta";
                }
                else
                {
                    reg.Resp73 = "Incorrecta";
                }
            }
            else if (rdbres2preg73.Checked == true)
            {
                if (rdbres2preg73.Text.TrimEnd() == resppreg73)
                {
                    reg.Resp73 = "Correcta";
                }
                else
                {
                    reg.Resp73 = "Incorrecta";
                }
            }
            else if (rdbres3preg73.Checked == true)
            {
                if (rdbres3preg73.Text.TrimEnd() == resppreg73)
                {
                    reg.Resp73 = "Correcta";
                }
                else
                {
                    reg.Resp73 = "Incorrecta";
                }
            }
            else if (rdbres4preg73.Checked == true)
            {
                if (rdbres4preg73.Text.TrimEnd() == resppreg73)
                {
                    reg.Resp73 = "Correcta";
                }
                else
                {
                    reg.Resp73 = "Incorrecta";
                }
            }

            if (rdbres1preg74.Checked == true)
            {
                if (rdbres1preg74.Text.TrimEnd() == resppreg74)
                {
                    reg.Resp74 = "Correcta";
                }
                else
                {
                    reg.Resp74 = "Incorrecta";
                }
            }
            else if (rdbres2preg74.Checked == true)
            {
                if (rdbres2preg74.Text.TrimEnd() == resppreg74)
                {
                    reg.Resp74 = "Correcta";
                }
                else
                {
                    reg.Resp74 = "Incorrecta";
                }
            }
            else if (rdbres3preg74.Checked == true)
            {
                if (rdbres3preg74.Text.TrimEnd() == resppreg74)
                {
                    reg.Resp74 = "Correcta";
                }
                else
                {
                    reg.Resp74 = "Incorrecta";
                }
            }
            else if (rdbres4preg74.Checked == true)
            {
                if (rdbres4preg74.Text.TrimEnd() == resppreg74)
                {
                    reg.Resp74 = "Correcta";
                }
                else
                {
                    reg.Resp74 = "Incorrecta";
                }
            }

            if (rdbres1preg75.Checked == true)
            {
                if (rdbres1preg75.Text.TrimEnd() == resppreg75)
                {
                    reg.Resp75 = "Correcta";
                }
                else
                {
                    reg.Resp75 = "Incorrecta";
                }
            }
            else if (rdbres2preg75.Checked == true)
            {
                if (rdbres2preg75.Text.TrimEnd() == resppreg75)
                {
                    reg.Resp75 = "Correcta";
                }
                else
                {
                    reg.Resp75 = "Incorrecta";
                }
            }
            else if (rdbres3preg75.Checked == true)
            {
                if (rdbres3preg75.Text.TrimEnd() == resppreg75)
                {
                    reg.Resp75 = "Correcta";
                }
                else
                {
                    reg.Resp75 = "Incorrecta";
                }
            }
            else if (rdbres4preg75.Checked == true)
            {
                if (rdbres4preg75.Text.TrimEnd() == resppreg75)
                {
                    reg.Resp75 = "Correcta";
                }
                else
                {
                    reg.Resp75 = "Incorrecta";
                }
            }
        }
    }
}