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
        public static bool resppreg41, resppreg42, resppreg43, resppreg44, resppreg45;

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

            nva.JalarPreg42();

            Image42.ImageUrl = ("~/ImagenesDePreguntas/42.jpg");
            lblpregunta42.Text = nva.Preg1;
            rdbres1preg42.Text = nva.Op1;
            rdbres2preg42.Text = nva.Op2;
            rdbres3preg42.Text = nva.Op3;
            rdbres4preg42.Text = nva.Op4;

            nva.JalarPreg43();

            Image43.ImageUrl = ("~/ImagenesDePreguntas/43.jpg");
            lblpregunta43.Text = nva.Preg1;
            rdbres1preg43.Text = nva.Op1;
            rdbres2preg43.Text = nva.Op2;
            rdbres3preg43.Text = nva.Op3;
            rdbres4preg43.Text = nva.Op4;

            nva.JalarPreg44();

            Image44.ImageUrl = ("~/ImagenesDePreguntas/44.jpg");
            lblpregunta44.Text = nva.Preg1;
            rdbres1preg44.Text = nva.Op1;
            rdbres2preg44.Text = nva.Op2;
            rdbres3preg44.Text = nva.Op3;
            rdbres4preg44.Text = nva.Op4;

            nva.JalarPreg45();

            Image45.ImageUrl = ("~/ImagenesDePreguntas/45.jpg");
            lblpregunta45.Text = nva.Preg1;
            rdbres1preg45.Text = nva.Op1;
            rdbres2preg45.Text = nva.Op2;
            rdbres3preg45.Text = nva.Op3;
            rdbres4preg45.Text = nva.Op4;
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
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg41.Checked == true)
            {
                resppreg41 = true;
                SQL_registro.resp41 = "Correcta";
            }
            else
            {
                resppreg41 = false;
                SQL_registro.resp41 = "Incorrecta";
            }


            if (rdbres4preg42.Checked == true)
            {
                resppreg42 = true;
                SQL_registro.resp42 = "Correcta";
            }
            else
            {
                resppreg42 = false;
                SQL_registro.resp42 = "Incorrecta";
            }


            if (rdbres2preg43.Checked == true)
            {
                resppreg43 = true;
                SQL_registro.resp43 = "Correcta";
            }
            else
            {
                resppreg43 = false;
                SQL_registro.resp43 = "Incorrecta";
            }


            if (rdbres4preg44.Checked == true)
            {
                resppreg44 = true;
                SQL_registro.resp44 = "Correcta";
            }
            else
            {
                resppreg44 = false;
                SQL_registro.resp44 = "Incorrecta";
            }


            if (rdbres3preg45.Checked == true)
            {
                resppreg45 = true;
                SQL_registro.resp45 = "Correcta";
            }
            else
            {
                resppreg45 = false;
                SQL_registro.resp45 = "Incorrecta";
            }
        }
    }
}