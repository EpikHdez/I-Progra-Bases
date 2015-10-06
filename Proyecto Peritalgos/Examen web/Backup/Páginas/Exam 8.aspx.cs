using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_8 : System.Web.UI.Page
    {
        public static string resppreg36, resppreg37, resppreg38, resppreg39, resppreg40;

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
            nva.JalarPreg36();

            Image36.ImageUrl = ("~/ImagenesDePreguntas/36.jpg");
            lblpregunta36.Text = nva.Preg1;
            rdbres1preg36.Text = nva.Op1;
            rdbres2preg36.Text = nva.Op2;
            rdbres3preg36.Text = nva.Op3;
            rdbres4preg36.Text = nva.Op4;
            resppreg36 = nva.Resp.TrimEnd();

            nva.JalarPreg37();

            Image37.ImageUrl = ("~/ImagenesDePreguntas/37.jpg");
            lblpregunta37.Text = nva.Preg1;
            rdbres1preg37.Text = nva.Op1;
            rdbres2preg37.Text = nva.Op2;
            rdbres3preg37.Text = nva.Op3;
            rdbres4preg37.Text = nva.Op4;
            resppreg37 = nva.Resp.TrimEnd();

            nva.JalarPreg38();

            Image38.ImageUrl = ("~/ImagenesDePreguntas/38.jpg");
            lblpregunta38.Text = nva.Preg1;
            rdbres1preg38.Text = nva.Op1;
            rdbres2preg38.Text = nva.Op2;
            rdbres3preg38.Text = nva.Op3;
            rdbres4preg38.Text = nva.Op4;
            resppreg38 = nva.Resp.TrimEnd();

            nva.JalarPreg39();

            Image39.ImageUrl = ("~/ImagenesDePreguntas/39.jpg");
            lblpregunta39.Text = nva.Preg1;
            rdbres1preg39.Text = nva.Op1;
            rdbres2preg39.Text = nva.Op2;
            rdbres3preg39.Text = nva.Op3;
            rdbres4preg39.Text = nva.Op4;
            resppreg39 = nva.Resp.TrimEnd(); 

            nva.JalarPreg40();

            Image40.ImageUrl = ("~/ImagenesDePreguntas/40.jpg");
            lblpregunta40.Text = nva.Preg1;
            rdbres1preg40.Text = nva.Op1;
            rdbres2preg40.Text = nva.Op2;
            rdbres3preg40.Text = nva.Op3;
            rdbres4preg40.Text = nva.Op4;
            resppreg40 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 9.aspx");
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

            if (rdbres1preg36.Checked == true)
            {
                if (rdbres1preg36.Text.TrimEnd() == resppreg36)
                {
                    reg.Resp36 = "Correcta";
                }
                else
                {
                    reg.Resp36 = "Incorrecta";
                }
            }
            else if (rdbres2preg36.Checked == true)
            {
                if (rdbres2preg36.Text.TrimEnd() == resppreg36)
                {
                    reg.Resp36 = "Correcta";
                }
                else
                {
                    reg.Resp36 = "Incorrecta";
                }
            }
            else if (rdbres3preg36.Checked == true)
            {
                if (rdbres3preg36.Text.TrimEnd() == resppreg36)
                {
                    reg.Resp36 = "Correcta";
                }
                else
                {
                    reg.Resp36 = "Incorrecta";
                }
            }
            else if (rdbres4preg36.Checked == true)
            {
                if (rdbres4preg36.Text.TrimEnd() == resppreg36)
                {
                    reg.Resp36 = "Correcta";
                }
                else
                {
                    reg.Resp36 = "Incorrecta";
                }
            }


            if (rdbres1preg37.Checked == true)
            {
                if (rdbres1preg37.Text.TrimEnd() == resppreg37)
                {
                    reg.Resp37 = "Correcta";
                }
                else
                {
                    reg.Resp37 = "Incorrecta";
                }
            }
            else if (rdbres2preg37.Checked == true)
            {
                if (rdbres2preg37.Text.TrimEnd() == resppreg37)
                {
                    reg.Resp37 = "Correcta";
                }
                else
                {
                    reg.Resp37 = "Incorrecta";
                }
            }
            else if (rdbres3preg37.Checked == true)
            {
                if (rdbres3preg37.Text.TrimEnd() == resppreg37)
                {
                    reg.Resp37 = "Correcta";
                }
                else
                {
                    reg.Resp37 = "Incorrecta";
                }
            }
            else if (rdbres4preg37.Checked == true)
            {
                if (rdbres4preg37.Text.TrimEnd() == resppreg37)
                {
                    reg.Resp37 = "Correcta";
                }
                else
                {
                    reg.Resp37 = "Incorrecta";
                }
            }

            if (rdbres1preg38.Checked == true)
            {
                if (rdbres1preg38.Text.TrimEnd() == resppreg38)
                {
                    reg.Resp38 = "Correcta";
                }
                else
                {
                    reg.Resp38 = "Incorrecta";
                }
            }
            else if (rdbres2preg38.Checked == true)
            {
                if (rdbres2preg38.Text.TrimEnd() == resppreg38)
                {
                    reg.Resp38 = "Correcta";
                }
                else
                {
                    reg.Resp38 = "Incorrecta";
                }
            }
            else if (rdbres3preg38.Checked == true)
            {
                if (rdbres3preg38.Text.TrimEnd() == resppreg38)
                {
                    reg.Resp38 = "Correcta";
                }
                else
                {
                    reg.Resp38 = "Incorrecta";
                }
            }
            else if (rdbres4preg38.Checked == true)
            {
                if (rdbres4preg38.Text.TrimEnd() == resppreg38)
                {
                    reg.Resp38 = "Correcta";
                }
                else
                {
                    reg.Resp38 = "Incorrecta";
                }
            }

            if (rdbres1preg39.Checked == true)
            {
                if (rdbres1preg39.Text.TrimEnd() == resppreg39)
                {
                    reg.Resp39 = "Correcta";
                }
                else
                {
                    reg.Resp39 = "Incorrecta";
                }
            }
            else if (rdbres2preg39.Checked == true)
            {
                if (rdbres2preg39.Text.TrimEnd() == resppreg39)
                {
                    reg.Resp39 = "Correcta";
                }
                else
                {
                    reg.Resp39 = "Incorrecta";
                }
            }
            else if (rdbres3preg39.Checked == true)
            {
                if (rdbres3preg39.Text.TrimEnd() == resppreg39)
                {
                    reg.Resp39 = "Correcta";
                }
                else
                {
                    reg.Resp39 = "Incorrecta";
                }
            }
            else if (rdbres4preg39.Checked == true)
            {
                if (rdbres4preg39.Text.TrimEnd() == resppreg39)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp39 = "Incorrecta";
                }
            }

            if (rdbres1preg40.Checked == true)
            {
                if (rdbres1preg40.Text.TrimEnd() == resppreg40)
                {
                    reg.Resp40 = "Correcta";
                }
                else
                {
                    reg.Resp40 = "Incorrecta";
                }
            }
            else if (rdbres2preg40.Checked == true)
            {
                if (rdbres2preg40.Text.TrimEnd() == resppreg40)
                {
                    reg.Resp40 = "Correcta";
                }
                else
                {
                    reg.Resp40 = "Incorrecta";
                }
            }
            else if (rdbres3preg40.Checked == true)
            {
                if (rdbres3preg40.Text.TrimEnd() == resppreg40)
                {
                    reg.Resp40 = "Correcta";
                }
                else
                {
                    reg.Resp40 = "Incorrecta";
                }
            }
            else if (rdbres4preg40.Checked == true)
            {
                if (rdbres4preg40.Text.TrimEnd() == resppreg40)
                {
                    reg.Resp40 = "Correcta";
                }
                else
                {
                    reg.Resp40 = "Incorrecta";
                }
            }
        }
    }
}