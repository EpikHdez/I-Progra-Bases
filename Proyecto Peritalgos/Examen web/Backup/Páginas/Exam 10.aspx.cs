using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_10 : System.Web.UI.Page
    {
        public static string resppreg46, resppreg47, resppreg48, resppreg49, resppreg50;

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
            nva.JalarPreg46();

            Image46.ImageUrl = ("~/ImagenesDePreguntas/46.jpg");
            lblpregunta46.Text = nva.Preg1;
            rdbres1preg46.Text = nva.Op1;
            rdbres2preg46.Text = nva.Op2;
            rdbres3preg46.Text = nva.Op3;
            rdbres4preg46.Text = nva.Op4;
			resppreg46 = nva.Resp.TrimEnd();

            nva.JalarPreg47();

            Image47.ImageUrl = ("~/ImagenesDePreguntas/47.jpg");
            lblpregunta47.Text = nva.Preg1;
            rdbres1preg47.Text = nva.Op1;
            rdbres2preg47.Text = nva.Op2;
            rdbres3preg47.Text = nva.Op3;
            rdbres4preg47.Text = nva.Op4;
			resppreg47 = nva.Resp.TrimEnd();

            nva.JalarPreg48();

            Image48.ImageUrl = ("~/ImagenesDePreguntas/48.jpg");
            lblpregunta48.Text = nva.Preg1;
            rdbres1preg48.Text = nva.Op1;
            rdbres2preg48.Text = nva.Op2;
            rdbres3preg48.Text = nva.Op3;
            rdbres4preg48.Text = nva.Op4;
			resppreg48 = nva.Resp.TrimEnd();

            nva.JalarPreg49();

            Image49.ImageUrl = ("~/ImagenesDePreguntas/49.jpg");
            lblpregunta49.Text = nva.Preg1;
            rdbres1preg49.Text = nva.Op1;
            rdbres2preg49.Text = nva.Op2;
            rdbres3preg49.Text = nva.Op3;
            rdbres4preg49.Text = nva.Op4;
			resppreg49 = nva.Resp.TrimEnd();

            nva.JalarPreg50();

            Image50.ImageUrl = ("~/ImagenesDePreguntas/50.jpg");
            lblpregunta50.Text = nva.Preg1;
            rdbres1preg50.Text = nva.Op1;
            rdbres2preg50.Text = nva.Op2;
            rdbres3preg50.Text = nva.Op3;
            rdbres4preg50.Text = nva.Op4;
			resppreg50 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			guardado();
            Response.Redirect("Exam 11.aspx");
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

            if (rdbres1preg46.Checked == true)
            {
                if (rdbres1preg46.Text.TrimEnd() == resppreg46)
                {
                    reg.Resp46 = "Correcta";
                }
                else
                {
                    reg.Resp46 = "Incorrecta";
                }
            }
            else if (rdbres2preg46.Checked == true)
            {
                if (rdbres2preg46.Text.TrimEnd() == resppreg46)
                {
                    reg.Resp46 = "Correcta";
                }
                else
                {
                    reg.Resp46 = "Incorrecta";
                }
            }
            else if (rdbres3preg46.Checked == true)
            {
                if (rdbres3preg46.Text.TrimEnd() == resppreg46)
                {
                    reg.Resp46 = "Correcta";
                }
                else
                {
                    reg.Resp46 = "Incorrecta";
                }
            }
            else if (rdbres4preg46.Checked == true)
            {
                if (rdbres4preg46.Text.TrimEnd() == resppreg46)
                {
                    reg.Resp46 = "Correcta";
                }
                else
                {
                    reg.Resp46 = "Incorrecta";
                }
            }


            if (rdbres1preg47.Checked == true)
            {
                if (rdbres1preg47.Text.TrimEnd() == resppreg47)
                {
                    reg.Resp47 = "Correcta";
                }
                else
                {
                    reg.Resp47 = "Incorrecta";
                }
            }
            else if (rdbres2preg47.Checked == true)
            {
                if (rdbres2preg47.Text.TrimEnd() == resppreg47)
                {
                    reg.Resp47 = "Correcta";
                }
                else
                {
                    reg.Resp47 = "Incorrecta";
                }
            }
            else if (rdbres3preg47.Checked == true)
            {
                if (rdbres3preg47.Text.TrimEnd() == resppreg47)
                {
                    reg.Resp47 = "Correcta";
                }
                else
                {
                    reg.Resp47 = "Incorrecta";
                }
            }
            else if (rdbres4preg47.Checked == true)
            {
                if (rdbres4preg47.Text.TrimEnd() == resppreg47)
                {
                    reg.Resp47 = "Correcta";
                }
                else
                {
                    reg.Resp47 = "Incorrecta";
                }
            }

            if (rdbres1preg48.Checked == true)
            {
                if (rdbres1preg48.Text.TrimEnd() == resppreg48)
                {
                    reg.Resp48 = "Correcta";
                }
                else
                {
                    reg.Resp48 = "Incorrecta";
                }
            }
            else if (rdbres2preg48.Checked == true)
            {
                if (rdbres2preg48.Text.TrimEnd() == resppreg48)
                {
                    reg.Resp48 = "Correcta";
                }
                else
                {
                    reg.Resp48 = "Incorrecta";
                }
            }
            else if (rdbres3preg48.Checked == true)
            {
                if (rdbres3preg48.Text.TrimEnd() == resppreg48)
                {
                    reg.Resp48 = "Correcta";
                }
                else
                {
                    reg.Resp48 = "Incorrecta";
                }
            }
            else if (rdbres4preg48.Checked == true)
            {
                if (rdbres4preg48.Text.TrimEnd() == resppreg48)
                {
                    reg.Resp48 = "Correcta";
                }
                else
                {
                    reg.Resp48 = "Incorrecta";
                }
            }

            if (rdbres1preg49.Checked == true)
            {
                if (rdbres1preg49.Text.TrimEnd() == resppreg49)
                {
                    reg.Resp49 = "Correcta";
                }
                else
                {
                    reg.Resp49 = "Incorrecta";
                }
            }
            else if (rdbres2preg49.Checked == true)
            {
                if (rdbres2preg49.Text.TrimEnd() == resppreg49)
                {
                    reg.Resp49 = "Correcta";
                }
                else
                {
                    reg.Resp49 = "Incorrecta";
                }
            }
            else if (rdbres3preg49.Checked == true)
            {
                if (rdbres3preg49.Text.TrimEnd() == resppreg49)
                {
                    reg.Resp49 = "Correcta";
                }
                else
                {
                    reg.Resp49 = "Incorrecta";
                }
            }
            else if (rdbres4preg49.Checked == true)
            {
                if (rdbres4preg49.Text.TrimEnd() == resppreg49)
                {
                    reg.Resp49 = "Correcta";
                }
                else
                {
                    reg.Resp49 = "Incorrecta";
                }
            }

            if (rdbres1preg50.Checked == true)
            {
                if (rdbres1preg50.Text.TrimEnd() == resppreg50)
                {
                    reg.Resp50 = "Correcta";
                }
                else
                {
                    reg.Resp50 = "Incorrecta";
                }
            }
            else if (rdbres2preg50.Checked == true)
            {
                if (rdbres2preg50.Text.TrimEnd() == resppreg50)
                {
                    reg.Resp50 = "Correcta";
                }
                else
                {
                    reg.Resp50 = "Incorrecta";
                }
            }
            else if (rdbres3preg50.Checked == true)
            {
                if (rdbres3preg50.Text.TrimEnd() == resppreg50)
                {
                    reg.Resp50 = "Correcta";
                }
                else
                {
                    reg.Resp50 = "Incorrecta";
                }
            }
            else if (rdbres4preg50.Checked == true)
            {
                if (rdbres4preg50.Text.TrimEnd() == resppreg50)
                {
                    reg.Resp50 = "Correcta";
                }
                else
                {
                    reg.Resp50 = "Incorrecta";
                }
            }
        }
    }
}