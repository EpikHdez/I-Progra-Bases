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
        public static bool resppreg11, resppreg12, resppreg13, resppreg14, resppreg15;

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

            nva.JalarPreg12();

            lblpregunta12.Text = nva.Preg1;
            rdbres1preg12.Text = nva.Op1;
            rdbres2preg12.Text = nva.Op2;
            rdbres3preg12.Text = nva.Op3;
            rdbres4preg12.Text = nva.Op4;

            nva.JalarPreg13();

            lblpregunta13.Text = nva.Preg1;
            rdbres1preg13.Text = nva.Op1;
            rdbres2preg13.Text = nva.Op2;
            rdbres3preg13.Text = nva.Op3;
            rdbres4preg13.Text = nva.Op4;

            nva.JalarPreg14();

            imgpreg14.ImageUrl = ("~/ImagenesDePreguntas/14.jpg");
            lblpregunta14.Text = nva.Preg1;
            rdbres1preg14.Text = nva.Op1;
            rdbres2preg14.Text = nva.Op2;
            rdbres3preg14.Text = nva.Op3;
            rdbres4preg14.Text = nva.Op4;

            nva.JalarPreg15();

            Imgpreg15.ImageUrl = ("~/ImagenesDePreguntas/15.jpg");
            lblpregunta15.Text = nva.Preg1;
            rdbres1preg15.Text = nva.Op1;
            rdbres2preg15.Text = nva.Op2;
            rdbres3preg15.Text = nva.Op3;
            rdbres4preg15.Text = nva.Op4;
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
        }

        public void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg11.Checked == true)
            {
                resppreg11 = true;
                SQL_registro.resp11 = "Correcto";
            }
            else
            {
                resppreg11 = false;
                SQL_registro.resp11 = "Incorrecto";
            }


            if (rdbres4preg12.Checked == true)
            {
                resppreg12 = true;
                SQL_registro.resp12 = "Correcto";
            }
            else
            {
                resppreg12 = false;
                SQL_registro.resp12 = "Incorrecto";
            }


            if (rdbres4preg13.Checked == true)
            {
                resppreg13 = true;
                SQL_registro.resp13 = "Correcto";
            }
            else
            {
                resppreg13 = false;
                SQL_registro.resp13 = "Incorrecto";
            }


            if (rdbres1preg14.Checked == true)
            {
                resppreg14 = true;
                SQL_registro.resp14 = "Correcto";
            }
            else
            {
                resppreg14 = false;
                SQL_registro.resp14 = "Incorrecto";
            }


            if (rdbres4preg15.Checked == true)
            {
                resppreg15 = true;
                SQL_registro.resp15 = "Correcto";
            }
            else
            {
                resppreg15 = false;
                SQL_registro.resp15 = "Incorrecto";
            }
        }
    }
}