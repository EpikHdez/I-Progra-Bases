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
        public static bool resppreg6, resppreg7, resppreg8, resppreg9, resppreg10;

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

            nva.JalarPreg7();

            lblpregunta7.Text = nva.Preg1;
            rdbres1preg7.Text = nva.Op1;
            rdbres2preg7.Text = nva.Op2;
            rdbres3preg7.Text = nva.Op3;
            rdbres4preg7.Text = nva.Op4;

            nva.JalarPreg8();

            lblpregunta8.Text = nva.Preg1;
            rdbres1preg8.Text = nva.Op1;
            rdbres2preg8.Text = nva.Op2;
            rdbres3preg8.Text = nva.Op3;
            rdbres4preg8.Text = nva.Op4;

            nva.JalarPreg9();

            lblpregunta9.Text = nva.Preg1;
            rdbres1preg9.Text = nva.Op1;
            rdbres2preg9.Text = nva.Op2;
            rdbres3preg9.Text = nva.Op3;
            rdbres4preg9.Text = nva.Op4;

            nva.JalarPreg10();

            lblpregunta10.Text = nva.Preg1;
            rdbres1preg10.Text = nva.Op1;
            rdbres2preg10.Text = nva.Op2;
            rdbres3preg10.Text = nva.Op3;
            rdbres4preg10.Text = nva.Op4;
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
        }

        public void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres4preg6.Checked == true)
            {
                resppreg6 = true;
                SQL_registro.resp6 = "Correcta";
            }
            else
            {
                resppreg6 = false;
                SQL_registro.resp6 = "Incorrecta";
            }


            if (rdbres2preg7.Checked == true)
            {
                resppreg7 = true;
                SQL_registro.resp7 = "Correcta";
            }
            else
            {
                resppreg7 = false;
                SQL_registro.resp7 = "Incorrecta";
            }


            if (rdbres1preg8.Checked == true)
            {
                resppreg8 = true;
                SQL_registro.resp8 = "Correcta";
            }
            else
            {
                resppreg8 = false;
                SQL_registro.resp8 = "Incorrecta";
            }


            if (rdbres3preg9.Checked == true)
            {
                resppreg9 = true;
                SQL_registro.resp9 = "Correcta";
            }
            else
            {
                resppreg9 = false;
                SQL_registro.resp9 = "Incorrecta";
            }


            if (rdbres1preg10.Checked == true)
            {
                resppreg10 = true;
                SQL_registro.resp10 = "Correcta";
            }
            else
            {
                resppreg10 = false;
                SQL_registro.resp10 = "Incorrecta";
            }
        }
    }
}