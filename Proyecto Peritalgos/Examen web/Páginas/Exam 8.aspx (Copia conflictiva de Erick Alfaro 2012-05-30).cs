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
        public static bool resppreg36, resppreg37, resppreg38, resppreg39, resppreg40;

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

            nva.JalarPreg37();

            Image37.ImageUrl = ("~/ImagenesDePreguntas/37.jpg");
            lblpregunta37.Text = nva.Preg1;
            rdbres1preg37.Text = nva.Op1;
            rdbres2preg37.Text = nva.Op2;
            rdbres3preg37.Text = nva.Op3;
            rdbres4preg37.Text = nva.Op4;

            nva.JalarPreg38();

            Image38.ImageUrl = ("~/ImagenesDePreguntas/38.jpg");
            lblpregunta38.Text = nva.Preg1;
            rdbres1preg38.Text = nva.Op1;
            rdbres2preg38.Text = nva.Op2;
            rdbres3preg38.Text = nva.Op3;
            rdbres4preg38.Text = nva.Op4;

            nva.JalarPreg39();

            Image39.ImageUrl = ("~/ImagenesDePreguntas/39.jpg");
            lblpregunta39.Text = nva.Preg1;
            rdbres1preg39.Text = nva.Op1;
            rdbres2preg39.Text = nva.Op2;
            rdbres3preg39.Text = nva.Op3;
            rdbres4preg39.Text = nva.Op4;

            nva.JalarPreg40();

            Image40.ImageUrl = ("~/ImagenesDePreguntas/40.jpg");
            lblpregunta40.Text = nva.Preg1;
            rdbres1preg40.Text = nva.Op1;
            rdbres2preg40.Text = nva.Op2;
            rdbres3preg40.Text = nva.Op3;
            rdbres4preg40.Text = nva.Op4;
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
        }

        private void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres2preg36.Checked == true)
            {
                resppreg36 = true;
                SQL_registro.resp36 = "Correcta";
            }
            else
            {
                resppreg36 = false;
                SQL_registro.resp36 = "Incorrecta";
            }


            if (rdbres2preg37.Checked == true)
            {
                resppreg37 = true;
                SQL_registro.resp37 = "Correcta";
            }
            else
            {
                resppreg37 = false;
                SQL_registro.resp37 = "Incorrecta";
            }


            if (rdbres3preg38.Checked == true)
            {
                resppreg38 = true;
                SQL_registro.resp38 = "Correcta";
            }
            else
            {
                resppreg38 = false;
                SQL_registro.resp38 = "Incorrecta";
            }


            if (rdbres1preg39.Checked == true)
            {
                resppreg39 = true;
                SQL_registro.resp39 = "Correcta";
            }
            else
            {
                resppreg39 = false;
                SQL_registro.resp39 = "Incorrecta";
            }


            if (rdbres1preg40.Checked == true)
            {
                resppreg40 = true;
                SQL_registro.resp40 = "Correcta";
            }
            else
            {
                resppreg40 = false;
                SQL_registro.resp40 = "Incorrecta";
            }
        }
    }
}