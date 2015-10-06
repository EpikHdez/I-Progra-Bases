using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_9 : System.Web.UI.Page
    {
        public static string resppreg41, resppreg42, resppreg43, resppreg44, resppreg45;

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
            nva.JalarPreg41();

            Image41.ImageUrl = ("~/ImagenesDePreguntas/41.jpg");
            lblpregunta41.Text = nva.Preg1;
            rdbres1preg41.Text = nva.Op1;
            rdbres2preg41.Text = nva.Op2;
            rdbres3preg41.Text = nva.Op3;
            rdbres4preg41.Text = nva.Op4;
			resppreg41 = nva.Resp.TrimEnd();

            nva.JalarPreg42();

            Image42.ImageUrl = ("~/ImagenesDePreguntas/42.jpg");
            lblpregunta42.Text = nva.Preg1;
            rdbres1preg42.Text = nva.Op1;
            rdbres2preg42.Text = nva.Op2;
            rdbres3preg42.Text = nva.Op3;
            rdbres4preg42.Text = nva.Op4;
			resppreg42 = nva.Resp.TrimEnd();

            nva.JalarPreg43();

            Image43.ImageUrl = ("~/ImagenesDePreguntas/43.jpg");
            lblpregunta43.Text = nva.Preg1;
            rdbres1preg43.Text = nva.Op1;
            rdbres2preg43.Text = nva.Op2;
            rdbres3preg43.Text = nva.Op3;
            rdbres4preg43.Text = nva.Op4;
			resppreg43 = nva.Resp.TrimEnd();

            nva.JalarPreg44();

            Image44.ImageUrl = ("~/ImagenesDePreguntas/44.jpg");
            lblpregunta44.Text = nva.Preg1;
            rdbres1preg44.Text = nva.Op1;
            rdbres2preg44.Text = nva.Op2;
            rdbres3preg44.Text = nva.Op3;
            rdbres4preg44.Text = nva.Op4;
			resppreg44 = nva.Resp.TrimEnd();

            nva.JalarPreg45();

            Image45.ImageUrl = ("~/ImagenesDePreguntas/45.jpg");
            lblpregunta45.Text = nva.Preg1;
            rdbres1preg45.Text = nva.Op1;
            rdbres2preg45.Text = nva.Op2;
            rdbres3preg45.Text = nva.Op3;
            rdbres4preg45.Text = nva.Op4;
			resppreg45 = nva.Resp.TrimEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 10.aspx");
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

            if (rdbres1preg41.Checked == true)
            {
                if (rdbres1preg41.Text.TrimEnd() == resppreg41)
                {
                    reg.Resp41 = "Correcta";
                }
                else
                {
                    reg.Resp41 = "Incorrecta";
                }
            }
            else if (rdbres2preg41.Checked == true)
            {
                if (rdbres2preg41.Text.TrimEnd() == resppreg41)
                {
                    reg.Resp41 = "Correcta";
                }
                else
                {
                    reg.Resp41 = "Incorrecta";
                }
            }
            else if (rdbres3preg41.Checked == true)
            {
                if (rdbres3preg41.Text.TrimEnd() == resppreg41)
                {
                    reg.Resp41 = "Correcta";
                }
                else
                {
                    reg.Resp41 = "Incorrecta";
                }
            }
            else if (rdbres4preg41.Checked == true)
            {
                if (rdbres4preg41.Text.TrimEnd() == resppreg41)
                {
                    reg.Resp41 = "Correcta";
                }
                else
                {
                    reg.Resp41 = "Incorrecta";
                }
            }


            if (rdbres1preg42.Checked == true)
            {
                if (rdbres1preg42.Text.TrimEnd() == resppreg42)
                {
                    reg.Resp42 = "Correcta";
                }
                else
                {
                    reg.Resp42 = "Incorrecta";
                }
            }
            else if (rdbres2preg42.Checked == true)
            {
                if (rdbres2preg42.Text.TrimEnd() == resppreg42)
                {
                    reg.Resp42 = "Correcta";
                }
                else
                {
                    reg.Resp42 = "Incorrecta";
                }
            }
            else if (rdbres3preg42.Checked == true)
            {
                if (rdbres3preg42.Text.TrimEnd() == resppreg42)
                {
                    reg.Resp42 = "Correcta";
                }
                else
                {
                    reg.Resp42 = "Incorrecta";
                }
            }
            else if (rdbres4preg42.Checked == true)
            {
                if (rdbres4preg42.Text.TrimEnd() == resppreg42)
                {
                    reg.Resp42 = "Correcta";
                }
                else
                {
                    reg.Resp42 = "Incorrecta";
                }
            }

            if (rdbres1preg43.Checked == true)
            {
                if (rdbres1preg43.Text.TrimEnd() == resppreg43)
                {
                    reg.Resp43 = "Correcta";
                }
                else
                {
                    reg.Resp43 = "Incorrecta";
                }
            }
            else if (rdbres2preg43.Checked == true)
            {
                if (rdbres2preg43.Text.TrimEnd() == resppreg43)
                {
                    reg.Resp43 = "Correcta";
                }
                else
                {
                    reg.Resp43 = "Incorrecta";
                }
            }
            else if (rdbres3preg43.Checked == true)
            {
                if (rdbres3preg43.Text.TrimEnd() == resppreg43)
                {
                    reg.Resp43 = "Correcta";
                }
                else
                {
                    reg.Resp43 = "Incorrecta";
                }
            }
            else if (rdbres4preg43.Checked == true)
            {
                if (rdbres4preg43.Text.TrimEnd() == resppreg43)
                {
                    reg.Resp43 = "Correcta";
                }
                else
                {
                    reg.Resp43 = "Incorrecta";
                }
            }

            if (rdbres1preg44.Checked == true)
            {
                if (rdbres1preg44.Text.TrimEnd() == resppreg44)
                {
                    reg.Resp44 = "Correcta";
                }
                else
                {
                    reg.Resp44 = "Incorrecta";
                }
            }
            else if (rdbres2preg44.Checked == true)
            {
                if (rdbres2preg44.Text.TrimEnd() == resppreg44)
                {
                    reg.Resp44 = "Correcta";
                }
                else
                {
                    reg.Resp44 = "Incorrecta";
                }
            }
            else if (rdbres3preg44.Checked == true)
            {
                if (rdbres3preg44.Text.TrimEnd() == resppreg44)
                {
                    reg.Resp44 = "Correcta";
                }
                else
                {
                    reg.Resp44 = "Incorrecta";
                }
            }
            else if (rdbres4preg44.Checked == true)
            {
                if (rdbres4preg44.Text.TrimEnd() == resppreg44)
                {
                    reg.Resp44 = "Correcta";
                }
                else
                {
                    reg.Resp44 = "Incorrecta";
                }
            }

            if (rdbres1preg45.Checked == true)
            {
                if (rdbres1preg45.Text.TrimEnd() == resppreg45)
                {
                    reg.Resp45 = "Correcta";
                }
                else
                {
                    reg.Resp45 = "Incorrecta";
                }
            }
            else if (rdbres2preg45.Checked == true)
            {
                if (rdbres2preg45.Text.TrimEnd() == resppreg45)
                {
                    reg.Resp45 = "Correcta";
                }
                else
                {
                    reg.Resp45 = "Incorrecta";
                }
            }
            else if (rdbres3preg45.Checked == true)
            {
                if (rdbres3preg45.Text.TrimEnd() == resppreg45)
                {
                    reg.Resp45 = "Correcta";
                }
                else
                {
                    reg.Resp45 = "Incorrecta";
                }
            }
            else if (rdbres4preg45.Checked == true)
            {
                if (rdbres4preg45.Text.TrimEnd() == resppreg45)
                {
                    reg.Resp45 = "Correcta";
                }
                else
                {
                    reg.Resp45 = "Incorrecta";
                }
            }
        }
    }
}