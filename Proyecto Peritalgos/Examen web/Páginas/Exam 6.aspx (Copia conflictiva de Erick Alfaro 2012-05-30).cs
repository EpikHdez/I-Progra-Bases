using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_6 : System.Web.UI.Page
    {
        public static bool resppreg26, resppreg27, resppreg28, resppreg29, resppreg30;

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
            nva.JalarPreg26();

            Image26.ImageUrl = ("~/ImagenesDePreguntas/26.jpg");
            lblpregunta26.Text = nva.Preg1;
            rdbres1preg26.Text = nva.Op1;
            rdbres2preg26.Text = nva.Op2;
            rdbres3preg26.Text = nva.Op3;
            rdbres4preg26.Text = nva.Op4;

            nva.JalarPreg27();

            Image27.ImageUrl = ("~/ImagenesDePreguntas/27.jpg");
            lblpregunta27.Text = nva.Preg1;
            rdbres1preg27.Text = nva.Op1;
            rdbres2preg27.Text = nva.Op2;
            rdbres3preg27.Text = nva.Op3;
            rdbres4preg27.Text = nva.Op4;

            nva.JalarPreg28();

            Image28.ImageUrl = ("~/ImagenesDePreguntas/28.jpg");
            lblpregunta28.Text = nva.Preg1;
            rdbres1preg28.Text = nva.Op1;
            rdbres2preg28.Text = nva.Op2;
            rdbres3preg28.Text = nva.Op3;
            rdbres4preg28.Text = nva.Op4;

            nva.JalarPreg29();

            Image29.ImageUrl = ("~/ImagenesDePreguntas/29.jpg");
            lblpregunta29.Text = nva.Preg1;
            rdbres1preg29.Text = nva.Op1;
            rdbres2preg29.Text = nva.Op2;
            rdbres3preg29.Text = nva.Op3;
            rdbres4preg29.Text = nva.Op4;

            nva.JalarPreg30();

            Image30.ImageUrl = ("~/ImagenesDePreguntas/30.jpg");
            lblpregunta30.Text = nva.Preg1;
            rdbres1preg30.Text = nva.Op1;
            rdbres2preg30.Text = nva.Op2;
            rdbres3preg30.Text = nva.Op3;
            rdbres4preg30.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Exam 7.aspx");
            
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

            if (rdbres1preg26.Checked == true)
            {
                resppreg26 = true;
                SQL_registro.resp26 = "Correcta";
            }
            else
            {
                resppreg26 = false;
                SQL_registro.resp26 = "Incorrecta";
            }


            if (rdbres1preg27.Checked == true)
            {
                resppreg27 = true;
                SQL_registro.resp27 = "Correcta";
            }
            else
            {
                resppreg27 = false;
                SQL_registro.resp27 = "Incorrecta";
            }


            if (rdbres1preg28.Checked == true)
            {
                resppreg28 = true;
                SQL_registro.resp28 = "Correcta";
            }
            else
            {
                resppreg28 = false;
                SQL_registro.resp28 = "Incorrecta";
            }


            if (rdbres2preg29.Checked == true)
            {
                resppreg29 = true;
                SQL_registro.resp29 = "Correcta";
            }
            else
            {
                resppreg29 = false;
                SQL_registro.resp29 = "Incorrecta";
            }


            if (rdbres1preg30.Checked == true)
            {
                resppreg30 = true;
                SQL_registro.resp30 = "Correcta";
            }
            else
            {
                resppreg30 = false;
                SQL_registro.resp30 = "Incorrecta";
            }
        }
    }
}