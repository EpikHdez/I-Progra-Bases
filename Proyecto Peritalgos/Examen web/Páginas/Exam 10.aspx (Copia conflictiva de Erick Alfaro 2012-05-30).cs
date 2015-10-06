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
        public static bool resppreg46, resppreg47, resppreg48, resppreg49, resppreg50;

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

            nva.JalarPreg47();

            Image47.ImageUrl = ("~/ImagenesDePreguntas/47.jpg");
            lblpregunta47.Text = nva.Preg1;
            rdbres1preg47.Text = nva.Op1;
            rdbres2preg47.Text = nva.Op2;
            rdbres3preg47.Text = nva.Op3;
            rdbres4preg47.Text = nva.Op4;

            nva.JalarPreg48();

            Image48.ImageUrl = ("~/ImagenesDePreguntas/48.jpg");
            lblpregunta48.Text = nva.Preg1;
            rdbres1preg48.Text = nva.Op1;
            rdbres2preg48.Text = nva.Op2;
            rdbres3preg48.Text = nva.Op3;
            rdbres4preg48.Text = nva.Op4;

            nva.JalarPreg49();

            Image49.ImageUrl = ("~/ImagenesDePreguntas/49.jpg");
            lblpregunta49.Text = nva.Preg1;
            rdbres1preg49.Text = nva.Op1;
            rdbres2preg49.Text = nva.Op2;
            rdbres3preg49.Text = nva.Op3;
            rdbres4preg49.Text = nva.Op4;

            nva.JalarPreg50();

            Image50.ImageUrl = ("~/ImagenesDePreguntas/50.jpg");
            lblpregunta50.Text = nva.Preg1;
            rdbres1preg50.Text = nva.Op1;
            rdbres2preg50.Text = nva.Op2;
            rdbres3preg50.Text = nva.Op3;
            rdbres4preg50.Text = nva.Op4;
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
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg46.Checked == true)
            {
                resppreg46 = true;
                SQL_registro.resp46 = "Correcta";
            }
            else
            {
                resppreg46 = false;
                SQL_registro.resp46 = "Incorrecta";
            }


            if (rdbres1preg47.Checked == true)
            {
                resppreg47 = true;
                SQL_registro.resp47 = "Correcta";
            }
            else
            {
                resppreg47 = false;
                SQL_registro.resp47 = "Incorrecta";
            }


            if (rdbres2preg48.Checked == true)
            {
                resppreg48 = true;
                SQL_registro.resp48 = "Correcta";
            }
            else
            {
                resppreg48 = false;
                SQL_registro.resp48 = "Incorrecta";
            }


            if (rdbres1preg49.Checked == true)
            {
                resppreg49 = true;
                SQL_registro.resp49 = "Correcta";
            }
            else
            {
                resppreg49 = false;
                reg.Resp49 = "Incorrecta";
            }


            if (rdbres1preg50.Checked == true)
            {
                resppreg50 = true;
                SQL_registro.resp50 = "Correcta";
            }
            else
            {
                resppreg50 = false;
                SQL_registro.resp50 = "Incorrecta";
            }
        }
    }
}