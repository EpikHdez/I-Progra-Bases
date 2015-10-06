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
        public static string resppreg16, resppreg17, resppreg18, resppreg19, resppreg20;

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
            resppreg16 = nva.Resp.TrimEnd();

            nva.JalarPreg17();

            Image17.ImageUrl = ("~/ImagenesDePreguntas/17.jpg");
            lblpregunta17.Text = nva.Preg1;
            rdbres1preg17.Text = nva.Op1;
            rdbres2preg17.Text = nva.Op2;
            rdbres3preg17.Text = nva.Op3;
            rdbres4preg17.Text = nva.Op4;
            resppreg17 = nva.Resp.TrimEnd();

            nva.JalarPreg18();

            Image18.ImageUrl = ("~/ImagenesDePreguntas/18.jpg");
            lblpregunta18.Text = nva.Preg1;
            rdbres1preg18.Text = nva.Op1;
            rdbres2preg18.Text = nva.Op2;
            rdbres3preg18.Text = nva.Op3;
            rdbres4preg18.Text = nva.Op4;
            resppreg18 = nva.Resp.TrimEnd();

            nva.JalarPreg19();

            Image19.ImageUrl = ("~/ImagenesDePreguntas/19.jpg");
            lblpregunta19.Text = nva.Preg1;
            rdbres1preg19.Text = nva.Op1;
            rdbres2preg19.Text = nva.Op2;
            rdbres3preg19.Text = nva.Op3;
            rdbres4preg19.Text = nva.Op4;
            resppreg19 = nva.Resp.TrimEnd();

            nva.JalarPreg20();

            Image20.ImageUrl = ("~/ImagenesDePreguntas/20.jpg");
            lblpregunta20.Text = nva.Preg1;
            rdbres1preg20.Text = nva.Op1;
            rdbres2preg20.Text = nva.Op2;
            rdbres3preg20.Text = nva.Op3;
            rdbres4preg20.Text = nva.Op4;
            resppreg20 = nva.Resp.TrimEnd();
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

            if (Exam_1.seg == 0 && Exam_1.min == 0 && Exam_1.horas == 0)
            {
                guardado();
                Response.Redirect("Calificar examen.aspx");
            }
        }

        public void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg16.Checked == true)
            {
                if (rdbres1preg16.Text.TrimEnd() == resppreg16)
                {
                    reg.Resp16 = "Correcta";
                }
                else
                {
                    reg.Resp16 = "Incorrecta";
                }
            }
            else if (rdbres2preg16.Checked == true)
            {
                if (rdbres2preg16.Text.TrimEnd() == resppreg16)
                {
                    reg.Resp16 = "Correcta";
                }
                else
                {
                    reg.Resp16 = "Incorrecta";
                }
            }
            else if (rdbres3preg16.Checked == true)
            {
                if (rdbres3preg16.Text.TrimEnd() == resppreg16)
                {
                    reg.Resp16 = "Correcta";
                }
                else
                {
                    reg.Resp16 = "Incorrecta";
                }
            }
            else if (rdbres4preg16.Checked == true)
            {
                if (rdbres4preg16.Text.TrimEnd() == resppreg16)
                {
                    reg.Resp16 = "Correcta";
                }
                else
                {
                    reg.Resp16 = "Incorrecta";
                }
            }


            if (rdbres1preg17.Checked == true)
            {
                if (rdbres1preg17.Text.TrimEnd() == resppreg17)
                {
                    reg.Resp17 = "Correcta";
                }
                else
                {
                    reg.Resp17 = "Incorrecta";
                }
            }
            else if (rdbres2preg17.Checked == true)
            {
                if (rdbres2preg17.Text.TrimEnd() == resppreg17)
                {
                    reg.Resp17 = "Correcta";
                }
                else
                {
                    reg.Resp17 = "Incorrecta";
                }
            }
            else if (rdbres3preg17.Checked == true)
            {
                if (rdbres3preg17.Text.TrimEnd() == resppreg17)
                {
                    reg.Resp17 = "Correcta";
                }
                else
                {
                    reg.Resp17 = "Incorrecta";
                }
            }
            else if (rdbres4preg17.Checked == true)
            {
                if (rdbres4preg17.Text.TrimEnd() == resppreg17)
                {
                    reg.Resp17 = "Correcta";
                }
                else
                {
                    reg.Resp17 = "Incorrecta";
                }
            }

            if (rdbres1preg18.Checked == true)
            {
                if (rdbres1preg18.Text.TrimEnd() == resppreg18)
                {
                    reg.Resp18 = "Correcta";
                }
                else
                {
                    reg.Resp18 = "Incorrecta";
                }
            }
            else if (rdbres2preg18.Checked == true)
            {
                if (rdbres2preg18.Text.TrimEnd() == resppreg18)
                {
                    reg.Resp18 = "Correcta";
                }
                else
                {
                    reg.Resp18 = "Incorrecta";
                }
            }
            else if (rdbres3preg18.Checked == true)
            {
                if (rdbres3preg18.Text.TrimEnd() == resppreg18)
                {
                    reg.Resp18 = "Correcta";
                }
                else
                {
                    reg.Resp18 = "Incorrecta";
                }
            }
            else if (rdbres4preg18.Checked == true)
            {
                if (rdbres4preg18.Text.TrimEnd() == resppreg18)
                {
                    reg.Resp18 = "Correcta";
                }
                else
                {
                    reg.Resp18 = "Incorrecta";
                }
            }

            if (rdbres1preg19.Checked == true)
            {
                if (rdbres1preg19.Text.TrimEnd() == resppreg19)
                {
                    reg.Resp19 = "Correcta";
                }
                else
                {
                    reg.Resp19 = "Incorrecta";
                }
            }
            else if (rdbres2preg19.Checked == true)
            {
                if (rdbres2preg19.Text.TrimEnd() == resppreg19)
                {
                    reg.Resp19 = "Correcta";
                }
                else
                {
                    reg.Resp19 = "Incorrecta";
                }
            }
            else if (rdbres3preg19.Checked == true)
            {
                if (rdbres3preg19.Text.TrimEnd() == resppreg19)
                {
                    reg.Resp19 = "Correcta";
                }
                else
                {
                    reg.Resp19 = "Incorrecta";
                }
            }
            else if (rdbres4preg19.Checked == true)
            {
                if (rdbres4preg19.Text.TrimEnd() == resppreg19)
                {
                    reg.Resp19 = "Correcta";
                }
                else
                {
                    reg.Resp19 = "Incorrecta";
                }
            }

            if (rdbres1preg20.Checked == true)
            {
                if (rdbres1preg20.Text.TrimEnd() == resppreg20)
                {
                    reg.Resp20 = "Correcta";
                }
                else
                {
                    reg.Resp20 = "Incorrecta";
                }
            }
            else if (rdbres2preg20.Checked == true)
            {
                if (rdbres2preg20.Text.TrimEnd() == resppreg20)
                {
                    reg.Resp20 = "Correcta";
                }
                else
                {
                    reg.Resp20 = "Incorrecta";
                }
            }
            else if (rdbres3preg20.Checked == true)
            {
                if (rdbres3preg20.Text.TrimEnd() == resppreg20)
                {
                    reg.Resp20 = "Correcta";
                }
                else
                {
                    reg.Resp20 = "Incorrecta";
                }
            }
            else if (rdbres4preg20.Checked == true)
            {
                if (rdbres4preg20.Text.TrimEnd() == resppreg20)
                {
                    reg.Resp20 = "Correcta";
                }
                else
                {
                    reg.Resp20 = "Incorrecta";
                }
            }
        }
    }
}