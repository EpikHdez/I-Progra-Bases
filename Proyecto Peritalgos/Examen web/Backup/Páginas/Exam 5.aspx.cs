using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_5 : System.Web.UI.Page
    {
        public static string resppreg21, resppreg22, resppreg23, resppreg24, resppreg25;

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
            nva.JalarPreg21();

            Image21.ImageUrl = ("~/ImagenesDePreguntas/21.jpg");
            lblpregunta21.Text = nva.Preg1;
            rdbres1preg21.Text = nva.Op1;
            rdbres2preg21.Text = nva.Op2;
            rdbres3preg21.Text = nva.Op3;
            rdbres4preg21.Text = nva.Op4;
            resppreg21 = nva.Resp.TrimEnd();

            nva.JalarPreg22();

            Image22.ImageUrl = ("~/ImagenesDePreguntas/22.jpg");
            lblpregunta22.Text = nva.Preg1;
            rdbres1preg22.Text = nva.Op1;
            rdbres2preg22.Text = nva.Op2;
            rdbres3preg22.Text = nva.Op3;
            rdbres4preg22.Text = nva.Op4;
            resppreg22 = nva.Resp.TrimEnd();

            nva.JalarPreg23();

            Image23.ImageUrl = ("~/ImagenesDePreguntas/23.jpg");
            lblpregunta23.Text = nva.Preg1;
            rdbres1preg23.Text = nva.Op1;
            rdbres2preg23.Text = nva.Op2;
            rdbres3preg23.Text = nva.Op3;
            rdbres4preg23.Text = nva.Op4;
            resppreg23 = nva.Resp.TrimEnd();

            nva.JalarPreg24();

            Image24.ImageUrl = ("~/ImagenesDePreguntas/24.jpg");
            lblpregunta24.Text = nva.Preg1;
            rdbres1preg24.Text = nva.Op1;
            rdbres2preg24.Text = nva.Op2;
            rdbres3preg24.Text = nva.Op3;
            rdbres4preg24.Text = nva.Op4;
            resppreg24 = nva.Resp.TrimEnd();

            nva.JalarPreg25();

            Image25.ImageUrl = ("~/ImagenesDePreguntas/25.jpg");
            lblpregunta25.Text = nva.Preg1;
            rdbres1preg25.Text = nva.Op1;
            rdbres2preg25.Text = nva.Op2;
            rdbres3preg25.Text = nva.Op3;
            rdbres4preg25.Text = nva.Op4;
            resppreg25 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 6.aspx");
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

            if (rdbres1preg21.Checked == true)
            {
                if (rdbres1preg21.Text.TrimEnd() == resppreg21)
                {
                    reg.Resp21 = "Correcta";
                }
                else
                {
                    reg.Resp21 = "Incorrecta";
                }
            }
            else if (rdbres2preg21.Checked == true)
            {
                if (rdbres2preg21.Text.TrimEnd() == resppreg21)
                {
                    reg.Resp21 = "Correcta";
                }
                else
                {
                    reg.Resp21 = "Incorrecta";
                }
            }
            else if (rdbres3preg21.Checked == true)
            {
                if (rdbres3preg21.Text.TrimEnd() == resppreg21)
                {
                    reg.Resp21 = "Correcta";
                }
                else
                {
                    reg.Resp21 = "Incorrecta";
                }
            }
            else if (rdbres4preg21.Checked == true)
            {
                if (rdbres4preg21.Text.TrimEnd() == resppreg21)
                {
                    reg.Resp21 = "Correcta";
                }
                else
                {
                    reg.Resp21 = "Incorrecta";
                }
            }


            if (rdbres1preg22.Checked == true)
            {
                if (rdbres1preg22.Text.TrimEnd() == resppreg22)
                {
                    reg.Resp22 = "Correcta";                }
                else
                {
                    reg.Resp22 = "Incorrecta";
                }
            }
            else if (rdbres2preg22.Checked == true)
            {
                if (rdbres2preg22.Text.TrimEnd() == resppreg22)
                {
                    reg.Resp22 = "Correcta";
                }
                else
                {
                    reg.Resp22 = "Incorrecta";
                }
            }
            else if (rdbres3preg22.Checked == true)
            {
                if (rdbres3preg22.Text.TrimEnd() == resppreg22)
                {
                    reg.Resp22 = "Correcta";
                }
                else
                {
                    reg.Resp22 = "Incorrecta";
                }
            }
            else if (rdbres4preg22.Checked == true)
            {
                if (rdbres4preg22.Text.TrimEnd() == resppreg22)
                {
                    reg.Resp22 = "Correcta";
                }
                else
                {
                    reg.Resp22 = "Incorrecta";
                }
            }

            if (rdbres1preg23.Checked == true)
            {
                if (rdbres1preg23.Text.TrimEnd() == resppreg23)
                {
                    reg.Resp23 = "Correcta";
                }
                else
                {
                    reg.Resp23 = "Incorrecta";
                }
            }
            else if (rdbres2preg23.Checked == true)
            {
                if (rdbres2preg23.Text.TrimEnd() == resppreg23)
                {
                    reg.Resp23 = "Correcta";
                }
                else
                {
                    reg.Resp23 = "Incorrecta";
                }
            }
            else if (rdbres3preg23.Checked == true)
            {
                if (rdbres3preg23.Text.TrimEnd() == resppreg23)
                {
                    reg.Resp23 = "Correcta";
                }
                else
                {
                    reg.Resp23 = "Incorrecta";
                }
            }
            else if (rdbres4preg23.Checked == true)
            {
                if (rdbres4preg23.Text.TrimEnd() == resppreg23)
                {
                    reg.Resp23 = "Correcta";
                }
                else
                {
                    reg.Resp23 = "Incorrecta";
                }
            }

            if (rdbres1preg24.Checked == true)
            {
                if (rdbres1preg24.Text.TrimEnd() == resppreg24)
                {
                    reg.Resp24 = "Correcta";
                }
                else
                {
                    reg.Resp24 = "Incorrecta";
                }
            }
            else if (rdbres2preg24.Checked == true)
            {
                if (rdbres2preg24.Text.TrimEnd() == resppreg24)
                {
                    reg.Resp24 = "Correcta";
                }
                else
                {
                    reg.Resp24 = "Incorrecta";
                }
            }
            else if (rdbres3preg24.Checked == true)
            {
                if (rdbres3preg24.Text.TrimEnd() == resppreg24)
                {
                    reg.Resp24 = "Correcta";
                }
                else
                {
                    reg.Resp24 = "Incorrecta";
                }
            }
            else if (rdbres4preg24.Checked == true)
            {
                if (rdbres4preg24.Text.TrimEnd() == resppreg24)
                {
                    reg.Resp24 = "Correcta";
                }
                else
                {
                    reg.Resp24 = "Incorrecta";
                }
            }

            if (rdbres1preg25.Checked == true)
            {
                if (rdbres1preg25.Text.TrimEnd() == resppreg25)
                {
                    reg.Resp25 = "Correcta";
                }
                else
                {
                    reg.Resp25 = "Incorrecta";
                }
            }
            else if (rdbres2preg25.Checked == true)
            {
                if (rdbres2preg25.Text.TrimEnd() == resppreg25)
                {
                    reg.Resp25 = "Correcta";
                }
                else
                {
                    reg.Resp25 = "Incorrecta";
                }
            }
            else if (rdbres3preg25.Checked == true)
            {
                if (rdbres3preg25.Text.TrimEnd() == resppreg25)
                {
                    reg.Resp25 = "Correcta";
                }
                else
                {
                    reg.Resp25 = "Incorrecta";
                }
            }
            else if (rdbres4preg25.Checked == true)
            {
                if (rdbres4preg25.Text.TrimEnd() == resppreg25)
                {
                    reg.Resp25 = "Correcta";
                }
                else
                {
                    reg.Resp25 = "Incorrecta";
                }
            }
        }
    }
}