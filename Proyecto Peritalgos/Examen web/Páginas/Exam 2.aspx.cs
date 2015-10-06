using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_2 : System.Web.UI.Page
    {
        public static string resppreg6, resppreg7, resppreg8, resppreg9, resppreg10;

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
            nva.JalarPreg6();

            lblpregunta6.Text = nva.Preg1;
            rdbres1preg6.Text = nva.Op1;
            rdbres2preg6.Text = nva.Op2;
            rdbres3preg6.Text = nva.Op3;
            rdbres4preg6.Text = nva.Op4;
            resppreg6 = nva.Resp;

            nva.JalarPreg7();

            lblpregunta7.Text = nva.Preg1;
            rdbres1preg7.Text = nva.Op1;
            rdbres2preg7.Text = nva.Op2;
            rdbres3preg7.Text = nva.Op3;
            rdbres4preg7.Text = nva.Op4;
            resppreg7 = nva.Resp;

            nva.JalarPreg8();

            lblpregunta8.Text = nva.Preg1;
            rdbres1preg8.Text = nva.Op1;
            rdbres2preg8.Text = nva.Op2;
            rdbres3preg8.Text = nva.Op3;
            rdbres4preg8.Text = nva.Op4;
            resppreg8 = nva.Resp;

            nva.JalarPreg9();

            lblpregunta9.Text = nva.Preg1;
            rdbres1preg9.Text = nva.Op1;
            rdbres2preg9.Text = nva.Op2;
            rdbres3preg9.Text = nva.Op3;
            rdbres4preg9.Text = nva.Op4;
            resppreg9 = nva.Resp;

            nva.JalarPreg10();

            lblpregunta10.Text = nva.Preg1;
            rdbres1preg10.Text = nva.Op1;
            rdbres2preg10.Text = nva.Op2;
            rdbres3preg10.Text = nva.Op3;
            rdbres4preg10.Text = nva.Op4;
            resppreg10 = nva.Resp;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 3.aspx");
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

            if (rdbres1preg6.Checked == true)
            {
                if (rdbres1preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }
            else if (rdbres2preg6.Checked == true)
            {
                if (rdbres2preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }
            else if (rdbres3preg6.Checked == true)
            {
                if (rdbres3preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }
            else if (rdbres4preg6.Checked == true)
            {
                if (rdbres4preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }


            if (rdbres1preg7.Checked == true)
            {
                if (rdbres1preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }
            else if (rdbres2preg7.Checked == true)
            {
                if (rdbres2preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }
            else if (rdbres3preg7.Checked == true)
            {
                if (rdbres3preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }
            else if (rdbres4preg7.Checked == true)
            {
                if (rdbres4preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }

            if (rdbres1preg8.Checked == true)
            {
                if (rdbres1preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }
            else if (rdbres2preg8.Checked == true)
            {
                if (rdbres2preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }
            else if (rdbres3preg8.Checked == true)
            {
                if (rdbres3preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }
            else if (rdbres4preg8.Checked == true)
            {
                if (rdbres4preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }

            if (rdbres1preg9.Checked == true)
            {
                if (rdbres1preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }
            else if (rdbres2preg9.Checked == true)
            {
                if (rdbres2preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }
            else if (rdbres3preg9.Checked == true)
            {
                if (rdbres3preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }
            else if (rdbres4preg9.Checked == true)
            {
                if (rdbres4preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }

            if (rdbres1preg10.Checked == true)
            {
                if (rdbres1preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
            else if (rdbres2preg10.Checked == true)
            {
                if (rdbres2preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
            else if (rdbres3preg10.Checked == true)
            {
                if (rdbres3preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
            else if (rdbres4preg10.Checked == true)
            {
                if (rdbres4preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
        }
    }
}