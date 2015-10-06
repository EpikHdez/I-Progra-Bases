using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_3 : System.Web.UI.Page
    {
        public static string resppreg11, resppreg12, resppreg13, resppreg14, resppreg15;

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
            nva.JalarPreg11();

            lblpregunta11.Text = nva.Preg1;
            rdbres1preg11.Text = nva.Op1;
            rdbres2preg11.Text = nva.Op2;
            rdbres3preg11.Text = nva.Op3;
            rdbres4preg11.Text = nva.Op4;
            resppreg11 = nva.Resp.TrimEnd();

            nva.JalarPreg12();

            lblpregunta12.Text = nva.Preg1;
            rdbres1preg12.Text = nva.Op1;
            rdbres2preg12.Text = nva.Op2;
            rdbres3preg12.Text = nva.Op3;
            rdbres4preg12.Text = nva.Op4;
            resppreg12 = nva.Resp.TrimEnd();

            nva.JalarPreg13();

            lblpregunta13.Text = nva.Preg1;
            rdbres1preg13.Text = nva.Op1;
            rdbres2preg13.Text = nva.Op2;
            rdbres3preg13.Text = nva.Op3;
            rdbres4preg13.Text = nva.Op4;
            resppreg13 = nva.Resp.TrimEnd();

            nva.JalarPreg14();

            imgpreg14.ImageUrl = ("~/ImagenesDePreguntas/14.jpg");
            lblpregunta14.Text = nva.Preg1;
            rdbres1preg14.Text = nva.Op1;
            rdbres2preg14.Text = nva.Op2;
            rdbres3preg14.Text = nva.Op3;
            rdbres4preg14.Text = nva.Op4;
            resppreg14 = nva.Resp.TrimEnd();

            nva.JalarPreg15();

            Imgpreg15.ImageUrl = ("~/ImagenesDePreguntas/15.jpg");
            lblpregunta15.Text = nva.Preg1;
            rdbres1preg15.Text = nva.Op1;
            rdbres2preg15.Text = nva.Op2;
            rdbres3preg15.Text = nva.Op3;
            rdbres4preg15.Text = nva.Op4;
            resppreg15 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 4.aspx");
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

            if (rdbres1preg11.Checked == true)
            {
                if (rdbres1preg11.Text.TrimEnd() == resppreg11)
                {
                    reg.Resp11 = "Correcta";
                }
                else
                {
                    reg.Resp11 = "Incorrecta";
                }
            }
            else if (rdbres2preg11.Checked == true)
            {
                if (rdbres2preg11.Text.TrimEnd() == resppreg11)
                {
                    reg.Resp11 = "Correcta";
                }
                else
                {
                    reg.Resp11 = "Incorrecta";
                }
            }
            else if (rdbres3preg11.Checked == true)
            {
                if (rdbres3preg11.Text.TrimEnd() == resppreg11)
                {
                    reg.Resp11 = "Correcta";
                }
                else
                {
                    reg.Resp11 = "Incorrecta";
                }
            }
            else if (rdbres4preg11.Checked == true)
            {
                if (rdbres4preg11.Text.TrimEnd() == resppreg11)
                {
                    reg.Resp11 = "Correcta";
                }
                else
                {
                    reg.Resp11 = "Incorrecta";
                }
            }


            if (rdbres1preg12.Checked == true)
            {
                if (rdbres1preg12.Text.TrimEnd() == resppreg12)
                {
                    reg.Resp12 = "Correcta";
                }
                else
                {
                    reg.Resp12 = "Incorrecta";
                }
            }
            else if (rdbres2preg12.Checked == true)
            {
                if (rdbres2preg12.Text.TrimEnd() == resppreg12)
                {
                    reg.Resp12 = "Correcta";
                }
                else
                {
                    reg.Resp12 = "Incorrecta";
                }
            }
            else if (rdbres3preg12.Checked == true)
            {
                if (rdbres3preg12.Text.TrimEnd() == resppreg12)
                {
                    reg.Resp12 = "Correcta";
                }
                else
                {
                    reg.Resp12 = "Incorrecta";
                }
            }
            else if (rdbres4preg12.Checked == true)
            {
                if (rdbres4preg12.Text.TrimEnd() == resppreg12)
                {
                    reg.Resp12 = "Correcta";
                }
                else
                {
                    reg.Resp12 = "Incorrecta";
                }
            }

            if (rdbres1preg13.Checked == true)
            {
                if (rdbres1preg13.Text.TrimEnd() == resppreg13)
                {
                    reg.Resp13 = "Correcta";
                }
                else
                {
                    reg.Resp13 = "Incorrecta";
                }
            }
            else if (rdbres2preg13.Checked == true)
            {
                if (rdbres2preg13.Text.TrimEnd() == resppreg13)
                {
                    reg.Resp13 = "Correcta";
                }
                else
                {
                    reg.Resp13 = "Incorrecta";
                }
            }
            else if (rdbres3preg13.Checked == true)
            {
                if (rdbres3preg13.Text.TrimEnd() == resppreg13)
                {
                    reg.Resp13 = "Correcta";
                }
                else
                {
                    reg.Resp13 = "Incorrecta";
                }
            }
            else if (rdbres4preg13.Checked == true)
            {
                if (rdbres4preg13.Text.TrimEnd() == resppreg13)
                {
                    reg.Resp13 = "Correcta";
                }
                else
                {
                    reg.Resp13 = "Incorrecta";
                }
            }

            if (rdbres1preg14.Checked == true)
            {
                if (rdbres1preg14.Text.TrimEnd() == resppreg14)
                {
                    reg.Resp14 = "Correcta";
                }
                else
                {
                    reg.Resp14 = "Incorrecta";
                }
            }
            else if (rdbres2preg14.Checked == true)
            {
                if (rdbres2preg14.Text.TrimEnd() == resppreg14)
                {
                    reg.Resp14 = "Correcta";
                }
                else
                {
                    reg.Resp14 = "Incorrecta";
                }
            }
            else if (rdbres3preg14.Checked == true)
            {
                if (rdbres3preg14.Text.TrimEnd() == resppreg14)
                {
                    reg.Resp14 = "Correcta";
                }
                else
                {
                    reg.Resp14 = "Incorrecta";
                }
            }
            else if (rdbres4preg14.Checked == true)
            {
                if (rdbres4preg14.Text.TrimEnd() == resppreg14)
                {
                    reg.Resp14 = "Correcta";
                }
                else
                {
                    reg.Resp14 = "Incorrecta";
                }
            }

            if (rdbres1preg15.Checked == true)
            {
                if (rdbres1preg15.Text.TrimEnd() == resppreg15)
                {
                    reg.Resp15 = "Correcta";
                }
                else
                {
                    reg.Resp15 = "Incorrecta";
                }
            }
            else if (rdbres2preg15.Checked == true)
            {
                if (rdbres2preg15.Text.TrimEnd() == resppreg15)
                {
                    reg.Resp15 = "Correcta";
                }
                else
                {
                    reg.Resp15 = "Incorrecta";
                }
            }
            else if (rdbres3preg15.Checked == true)
            {
                if (rdbres3preg15.Text.TrimEnd() == resppreg15)
                {
                    reg.Resp15 = "Correcta";
                }
                else
                {
                    reg.Resp15 = "Incorrecta";
                }
            }
            else if (rdbres4preg15.Checked == true)
            {
                if (rdbres4preg15.Text.TrimEnd() == resppreg15)
                {
                    reg.Resp15 = "Correcta";
                }
                else
                {
                    reg.Resp15 = "Incorrecta";
                }
            }
        }
    }
}