using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Exam_1 : System.Web.UI.Page
    {
        public static bool resppreg1, resppreg2, resppreg3, resppreg4, resppreg5;
        public static int horas, min, seg;

        protected void Page_Load(object sender, EventArgs e)
        {
            horas = int.Parse(txthoras.Text);
            min = int.Parse(txtmin.Text);
            seg = int.Parse(txtseg.Text);
            
            if (!IsPostBack)
               {
                    cargar();
               }
        }

        protected void cargar()
        {
            SQL_conection nva = new SQL_conection();
            nva.JalarPreg1();

            lblpregunta1.Text = nva.Preg1;
            rdbres1preg1.Text = nva.Op1;
            rdbres2preg1.Text = nva.Op2;
            rdbres3preg1.Text = nva.Op3;
            rdbres4preg1.Text = nva.Op4;

            nva.JalarPreg2();

            lblpregunta2.Text = nva.Preg1;
            rdbres1preg2.Text = nva.Op1;
            rdbres2preg2.Text = nva.Op2;
            rdbres3preg2.Text = nva.Op3;
            rdbres4preg2.Text = nva.Op4;

            nva.JalarPreg3();

            lblpregunta3.Text = nva.Preg1;
            rdbres1preg3.Text = nva.Op1;
            rdbres2preg3.Text = nva.Op2;
            rdbres3preg3.Text = nva.Op3;
            rdbres4preg3.Text = nva.Op4;

            nva.JalarPreg4();

            lblpregunta4.Text = nva.Preg1;
            rdbres1preg4.Text = nva.Op1;
            rdbres2preg4.Text = nva.Op2;
            rdbres3preg4.Text = nva.Op3;
            rdbres4preg4.Text = nva.Op4;

            nva.JalarPreg5();

            lblpregunta5.Text = nva.Preg1;
            rdbres1preg5.Text = nva.Op1;
            rdbres2preg5.Text = nva.Op2;
            rdbres3preg5.Text = nva.Op3;
            rdbres4preg5.Text = nva.Op4;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Guardado();
            Response.Redirect("Exam 2.aspx");
            
        }

        protected void Tiempo_Tick(object sender, EventArgs e)
        {
            seg = seg - 1;
            txtseg.Text = seg.ToString();

            if (seg == 0)
            {
                min = min - 1;
                txtmin.Text = min.ToString();
                seg = 59;
                txtseg.Text = seg.ToString();

                if (min == 0)
                {
                    min = 59;
                    txtmin.Text = min.ToString();

                    if (horas != 0)
                    {
                        horas = horas - 1;
                        txthoras.Text = horas.ToString();
                    }
                }
            }
        }

        private void Guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres3preg1.Checked == true)
            {
                resppreg1 = true;
                SQL_registro.resp1 = "Correcta";
            }
            else
            {
                resppreg1 = false;
                SQL_registro.resp1 = "Incorrecta";
            }


            if (rdbres1preg2.Checked == true)
            {
                resppreg2 = true;
                SQL_registro.resp2 = "Correcta";
            }
            else
            {
                resppreg2 = false;
                SQL_registro.resp2 = "Incorrecta";
            }


            if (rdbres1preg3.Checked == true)
            {
                resppreg3 = true;
                SQL_registro.resp3 = "Correcta";
            }
            else
            {
                resppreg3 = false;
                SQL_registro.resp3 = "Incorrecta";
            }


            if (rdbres4preg4.Checked == true)
            {
                resppreg4 = true;
                SQL_registro.resp4 = "Correcta";
            }
            else
            {
                resppreg4 = false;
                SQL_registro.resp4 = "Incorrecta";
            }


            if (rdbres1preg5.Checked == true)
            {
                resppreg5 = true;
                SQL_registro.resp5 = "Correcta";
            }
            else
            {
                resppreg5 = false;
                SQL_registro.resp5 = "Incorrecta";
            }
        }
    }
}