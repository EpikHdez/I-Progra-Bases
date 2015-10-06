using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_6 : System.Web.UI.Page
    {
        public static string resppreg26, resppreg27, resppreg28, resppreg29, resppreg30;

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
            nva.JalarPreg26();

            Image26.ImageUrl = ("~/ImagenesDePreguntas/26.jpg");
            lblpregunta26.Text = nva.Preg1;
            rdbres1preg26.Text = nva.Op1;
            rdbres2preg26.Text = nva.Op2;
            rdbres3preg26.Text = nva.Op3;
            rdbres4preg26.Text = nva.Op4;
            resppreg26 = nva.Resp.TrimEnd();

            nva.JalarPreg27();

            Image27.ImageUrl = ("~/ImagenesDePreguntas/27.jpg");
            lblpregunta27.Text = nva.Preg1;
            rdbres1preg27.Text = nva.Op1;
            rdbres2preg27.Text = nva.Op2;
            rdbres3preg27.Text = nva.Op3;
            rdbres4preg27.Text = nva.Op4;
            resppreg27 = nva.Resp.TrimEnd();

            nva.JalarPreg28();

            Image28.ImageUrl = ("~/ImagenesDePreguntas/28.jpg");
            lblpregunta28.Text = nva.Preg1;
            rdbres1preg28.Text = nva.Op1;
            rdbres2preg28.Text = nva.Op2;
            rdbres3preg28.Text = nva.Op3;
            rdbres4preg28.Text = nva.Op4;
            resppreg28 = nva.Resp.TrimEnd();

            nva.JalarPreg29();

            Image29.ImageUrl = ("~/ImagenesDePreguntas/29.jpg");
            lblpregunta29.Text = nva.Preg1;
            rdbres1preg29.Text = nva.Op1;
            rdbres2preg29.Text = nva.Op2;
            rdbres3preg29.Text = nva.Op3;
            rdbres4preg29.Text = nva.Op4;
            resppreg29 = nva.Resp.TrimEnd();

            nva.JalarPreg30();

            Image30.ImageUrl = ("~/ImagenesDePreguntas/30.jpg");
            lblpregunta30.Text = nva.Preg1;
            rdbres1preg30.Text = nva.Op1;
            rdbres2preg30.Text = nva.Op2;
            rdbres3preg30.Text = nva.Op3;
            rdbres4preg30.Text = nva.Op4;
            resppreg30 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 7.aspx");
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

            if (rdbres1preg26.Checked == true)
            {
                if (rdbres1preg26.Text.TrimEnd() == resppreg26)
                {
                    reg.Resp26 = "Correcta";
                }
                else
                {
                    reg.Resp26 = "Incorrecta";
                }
            }
            else if (rdbres2preg26.Checked == true)
            {
                if (rdbres2preg26.Text.TrimEnd() == resppreg26)
                {
                    reg.Resp26 = "Correcta";
                }
                else
                {
                    reg.Resp26 = "Incorrecta";
                }
            }
            else if (rdbres3preg26.Checked == true)
            {
                if (rdbres3preg26.Text.TrimEnd() == resppreg26)
                {
                    reg.Resp26 = "Correcta";
                }
                else
                {
                    reg.Resp26 = "Incorrecta";
                }
            }
            else if (rdbres4preg26.Checked == true)
            {
                if (rdbres4preg26.Text.TrimEnd() == resppreg26)
                {
                    reg.Resp26 = "Correcta";
                }
                else
                {
                    reg.Resp26 = "Incorrecta";
                }
            }


            if (rdbres1preg27.Checked == true)
            {
                if (rdbres1preg27.Text.TrimEnd() == resppreg27)
                {
                    reg.Resp27 = "Correcta";
                }
                else
                {
                    reg.Resp27 = "Incorrecta";
                }
            }
            else if (rdbres2preg27.Checked == true)
            {
                if (rdbres2preg27.Text.TrimEnd() == resppreg27)
                {
                    reg.Resp27 = "Correcta";
                }
                else
                {
                    reg.Resp27 = "Incorrecta";
                }
            }
            else if (rdbres3preg27.Checked == true)
            {
                if (rdbres3preg27.Text.TrimEnd() == resppreg27)
                {
                    reg.Resp27 = "Correcta";
                }
                else
                {
                    reg.Resp27 = "Incorrecta";
                }
            }
            else if (rdbres4preg27.Checked == true)
            {
                if (rdbres4preg27.Text.TrimEnd() == resppreg27)
                {
                    reg.Resp27 = "Correcta";
                }
                else
                {
                    reg.Resp27 = "Incorrecta";
                }
            }

            if (rdbres1preg28.Checked == true)
            {
                if (rdbres1preg28.Text.TrimEnd() == resppreg28)
                {
                    reg.Resp28 = "Correcta";
                }
                else
                {
                    reg.Resp28 = "Incorrecta";
                }
            }
            else if (rdbres2preg28.Checked == true)
            {
                if (rdbres2preg28.Text.TrimEnd() == resppreg28)
                {
                    reg.Resp28 = "Correcta";
                }
                else
                {
                    reg.Resp28 = "Incorrecta";
                }
            }
            else if (rdbres3preg28.Checked == true)
            {
                if (rdbres3preg28.Text.TrimEnd() == resppreg28)
                {
                    reg.Resp28 = "Correcta";
                }
                else
                {
                    reg.Resp28 = "Incorrecta";
                }
            }
            else if (rdbres4preg28.Checked == true)
            {
                if (rdbres4preg28.Text.TrimEnd() == resppreg28)
                {
                    reg.Resp28 = "Correcta";
                }
                else
                {
                    reg.Resp28 = "Incorrecta";
                }
            }

            if (rdbres1preg29.Checked == true)
            {
                if (rdbres1preg29.Text.TrimEnd() == resppreg29)
                {
                    reg.Resp29 = "Correcta";
                }
                else
                {
                    reg.Resp29 = "Incorrecta";
                }
            }
            else if (rdbres2preg29.Checked == true)
            {
                if (rdbres2preg29.Text.TrimEnd() == resppreg29)
                {
                    reg.Resp29 = "Correcta";
                }
                else
                {
                    reg.Resp29 = "Incorrecta";
                }
            }
            else if (rdbres3preg29.Checked == true)
            {
                if (rdbres3preg29.Text.TrimEnd() == resppreg29)
                {
                    reg.Resp29 = "Correcta";
                }
                else
                {
                    reg.Resp29 = "Incorrecta";
                }
            }
            else if (rdbres4preg29.Checked == true)
            {
                if (rdbres4preg29.Text.TrimEnd() == resppreg29)
                {
                    reg.Resp29 = "Correcta";
                }
                else
                {
                    reg.Resp29 = "Incorrecta";
                }
            }

            if (rdbres1preg30.Checked == true)
            {
                if (rdbres1preg30.Text.TrimEnd() == resppreg30)
                {
                    reg.Resp30 = "Correcta";
                }
                else
                {
                    reg.Resp30 = "Incorrecta";
                }
            }
            else if (rdbres2preg30.Checked == true)
            {
                if (rdbres2preg30.Text.TrimEnd() == resppreg30)
                {
                    reg.Resp30 = "Correcta";
                }
                else
                {
                    reg.Resp30 = "Incorrecta";
                }
            }
            else if (rdbres3preg30.Checked == true)
            {
                if (rdbres3preg30.Text.TrimEnd() == resppreg30)
                {
                    reg.Resp30 = "Correcta";
                }
                else
                {
                    reg.Resp30 = "Incorrecta";
                }
            }
            else if (rdbres4preg30.Checked == true)
            {
                if (rdbres4preg30.Text.TrimEnd() == resppreg30)
                {
                    reg.Resp30 = "Correcta";
                }
                else
                {
                    reg.Resp30 = "Incorrecta";
                }
            }
        }
    }
}