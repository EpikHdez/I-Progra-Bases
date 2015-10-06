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
        public static string resppreg61, resppreg62, resppreg63, resppreg64, resppreg65;

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
			resppreg61 = nva.Resp.TrimEnd();

            nva.JalarPreg62();

            Image62.ImageUrl = ("~/ImagenesDePreguntas/62.jpg");
            lblpregunta62.Text = nva.Preg1;
            rdbres1preg62.Text = nva.Op1;
            rdbres2preg62.Text = nva.Op2;
            rdbres3preg62.Text = nva.Op3;
            rdbres4preg62.Text = nva.Op4;
			resppreg62 = nva.Resp.TrimEnd();

            nva.JalarPreg63();

            Image63.ImageUrl = ("~/ImagenesDePreguntas/63.jpg");
            lblpregunta63.Text = nva.Preg1;
            rdbres1preg63.Text = nva.Op1;
            rdbres2preg63.Text = nva.Op2;
            rdbres3preg63.Text = nva.Op3;
            rdbres4preg63.Text = nva.Op4;
			resppreg63 = nva.Resp.TrimEnd();

            nva.JalarPreg64();

            Image64.ImageUrl = ("~/ImagenesDePreguntas/64.jpg");
            lblpregunta64.Text = nva.Preg1;
            rdbres1preg64.Text = nva.Op1;
            rdbres2preg64.Text = nva.Op2;
            rdbres3preg64.Text = nva.Op3;
            rdbres4preg64.Text = nva.Op4;
			resppreg64 = nva.Resp.TrimEnd();

            nva.JalarPreg65();

            Image65.ImageUrl = ("~/ImagenesDePreguntas/65.jpg");
            lblpregunta65.Text = nva.Preg1;
            rdbres1preg65.Text = nva.Op1;
            rdbres2preg65.Text = nva.Op2;
            rdbres3preg65.Text = nva.Op3;
            rdbres4preg65.Text = nva.Op4;
			resppreg65 = nva.Resp.TrimEnd();
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

            if (Exam_1.seg == 0 && Exam_1.min == 0 && Exam_1.horas == 0)
            {
                guardado();
                Response.Redirect("Calificar examen.aspx");
            }
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg61.Checked == true)
            {
                if (rdbres1preg61.Text.TrimEnd() == resppreg61)
                {
                    reg.Resp61 = "Correcta";
                }
                else
                {
                    reg.Resp61 = "Incorrecta";
                }
            }
            else if (rdbres2preg61.Checked == true)
            {
                if (rdbres2preg61.Text.TrimEnd() == resppreg61)
                {
                    reg.Resp61 = "Correcta";
                }
                else
                {
                    reg.Resp61 = "Incorrecta";
                }
            }
            else if (rdbres3preg61.Checked == true)
            {
                if (rdbres3preg61.Text.TrimEnd() == resppreg61)
                {
                    reg.Resp61 = "Correcta";
                }
                else
                {
                    reg.Resp61 = "Incorrecta";
                }
            }
            else if (rdbres4preg61.Checked == true)
            {
                if (rdbres4preg61.Text.TrimEnd() == resppreg61)
                {
                    reg.Resp61 = "Correcta";
                }
                else
                {
                    reg.Resp61 = "Incorrecta";
                }
            }


            if (rdbres1preg62.Checked == true)
            {
                if (rdbres1preg62.Text.TrimEnd() == resppreg62)
                {
                    reg.Resp62 = "Correcta";
                }
                else
                {
                    reg.Resp62 = "Incorrecta";
                }
            }
            else if (rdbres2preg62.Checked == true)
            {
                if (rdbres2preg62.Text.TrimEnd() == resppreg62)
                {
                    reg.Resp62 = "Correcta";
                }
                else
                {
                    reg.Resp62 = "Incorrecta";
                }
            }
            else if (rdbres3preg62.Checked == true)
            {
                if (rdbres3preg62.Text.TrimEnd() == resppreg62)
                {
                    reg.Resp62 = "Correcta";
                }
                else
                {
                    reg.Resp62 = "Incorrecta";
                }
            }
            else if (rdbres4preg62.Checked == true)
            {
                if (rdbres4preg62.Text.TrimEnd() == resppreg62)
                {
                    reg.Resp62 = "Correcta";
                }
                else
                {
                    reg.Resp62 = "Incorrecta";
                }
            }

            if (rdbres1preg63.Checked == true)
            {
                if (rdbres1preg63.Text.TrimEnd() == resppreg63)
                {
                    reg.Resp63 = "Correcta";
                }
                else
                {
                    reg.Resp63 = "Incorrecta";
                }
            }
            else if (rdbres2preg63.Checked == true)
            {
                if (rdbres2preg63.Text.TrimEnd() == resppreg63)
                {
                    reg.Resp63 = "Correcta";
                }
                else
                {
                    reg.Resp63 = "Incorrecta";
                }
            }
            else if (rdbres3preg63.Checked == true)
            {
                if (rdbres3preg63.Text.TrimEnd() == resppreg63)
                {
                    reg.Resp63 = "Correcta";
                }
                else
                {
                    reg.Resp63 = "Incorrecta";
                }
            }
            else if (rdbres4preg63.Checked == true)
            {
                if (rdbres4preg63.Text.TrimEnd() == resppreg63)
                {
                    reg.Resp63 = "Correcta";
                }
                else
                {
                    reg.Resp63 = "Incorrecta";
                }
            }

            if (rdbres1preg64.Checked == true)
            {
                if (rdbres1preg64.Text.TrimEnd() == resppreg64)
                {
                    reg.Resp64 = "Correcta";
                }
                else
                {
                    reg.Resp64 = "Incorrecta";
                }
            }
            else if (rdbres2preg64.Checked == true)
            {
                if (rdbres2preg64.Text.TrimEnd() == resppreg64)
                {
                    reg.Resp64 = "Correcta";
                }
                else
                {
                    reg.Resp64 = "Incorrecta";
                }
            }
            else if (rdbres3preg64.Checked == true)
            {
                if (rdbres3preg64.Text.TrimEnd() == resppreg64)
                {
                    reg.Resp64 = "Correcta";
                }
                else
                {
                    reg.Resp64 = "Incorrecta";
                }
            }
            else if (rdbres4preg64.Checked == true)
            {
                if (rdbres4preg64.Text.TrimEnd() == resppreg64)
                {
                    reg.Resp64 = "Correcta";
                }
                else
                {
                    reg.Resp64 = "Incorrecta";
                }
            }

            if (rdbres1preg65.Checked == true)
            {
                if (rdbres1preg65.Text.TrimEnd() == resppreg65)
                {
                    reg.Resp65 = "Correcta";
                }
                else
                {
                    reg.Resp65 = "Incorrecta";
                }
            }
            else if (rdbres2preg65.Checked == true)
            {
                if (rdbres2preg65.Text.TrimEnd() == resppreg65)
                {
                    reg.Resp65 = "Correcta";
                }
                else
                {
                    reg.Resp65 = "Incorrecta";
                }
            }
            else if (rdbres3preg65.Checked == true)
            {
                if (rdbres3preg65.Text.TrimEnd() == resppreg65)
                {
                    reg.Resp65 = "Correcta";
                }
                else
                {
                    reg.Resp65 = "Incorrecta";
                }
            }
            else if (rdbres4preg65.Checked == true)
            {
                if (rdbres4preg65.Text.TrimEnd() == resppreg65)
                {
                    reg.Resp65 = "Correcta";
                }
                else
                {
                    reg.Resp65 = "Incorrecta";
                }
            }
        }
    }
}