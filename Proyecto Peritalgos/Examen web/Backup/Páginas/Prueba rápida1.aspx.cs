using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;


namespace Examen_web.Páginas
{
    public partial class Prueba_rápida : System.Web.UI.Page
    {
        public static int horas, min, seg;
        public static string resppreg1, resppreg2, resppreg3, resppreg4, resppreg5;

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
            resppreg1 = nva.Resp.TrimEnd();

            nva.JalarPreg2();

            lblpregunta2.Text = nva.Preg1;
            rdbres1preg2.Text = nva.Op1;
            rdbres2preg2.Text = nva.Op2;
            rdbres3preg2.Text = nva.Op3;
            rdbres4preg2.Text = nva.Op4;
            resppreg2 = nva.Resp.TrimEnd();

            nva.JalarPreg3();

            lblpregunta3.Text = nva.Preg1;
            rdbres1preg3.Text = nva.Op1;
            rdbres2preg3.Text = nva.Op2;
            rdbres3preg3.Text = nva.Op3;
            rdbres4preg3.Text = nva.Op4;
            resppreg3 = nva.Resp.TrimEnd();

            nva.JalarPreg4();

            lblpregunta4.Text = nva.Preg1;
            rdbres1preg4.Text = nva.Op1;
            rdbres2preg4.Text = nva.Op2;
            rdbres3preg4.Text = nva.Op3;
            rdbres4preg4.Text = nva.Op4;
            resppreg4 = nva.Resp.TrimEnd();

            nva.JalarPreg5();

            lblpregunta5.Text = nva.Preg1;
            rdbres1preg5.Text = nva.Op1;
            rdbres2preg5.Text = nva.Op2;
            rdbres3preg5.Text = nva.Op3;
            rdbres4preg5.Text = nva.Op4;
            resppreg5 = nva.Resp.TrimEnd();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Prueba rápida2.aspx");
        }
        
        public void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg1.Checked == true)
            {
                if (rdbres1preg1.Text.TrimEnd() == resppreg1)
                {
                    reg.Resp1 = "Correcta";
                }
                else
                {
                    reg.Resp1 = "Incorrecta";
                }
            }
            else if (rdbres2preg1.Checked == true)
            {
                if (rdbres2preg1.Text.TrimEnd() == resppreg1)
                {
                    reg.Resp1 = "Correcta";
                }
                else
                {
                    reg.Resp1 = "Incorrecta";
                }
            }
            else if (rdbres3preg1.Checked == true)
            {
                if (rdbres3preg1.Text.TrimEnd() == resppreg1)
                {
                    reg.Resp1 = "Correcta";
                }
                else
                {
                    reg.Resp1 = "Incorrecta";
                }
            }
            else if (rdbres4preg1.Checked == true)
            {
                if (rdbres4preg1.Text.TrimEnd() == resppreg1)
                {
                    reg.Resp1 = "Correcta";
                }
                else
                {
                    reg.Resp1 = "Incorrecta";
                }
            }


            if (rdbres1preg2.Checked == true)
            {
                if (rdbres1preg2.Text.TrimEnd() == resppreg2)
                {
                    reg.Resp2 = "Correcta";
                }
                else
                {
                    reg.Resp2 = "Incorrecta";
                }
            }
            else if (rdbres2preg2.Checked == true)
            {
                if (rdbres2preg2.Text.TrimEnd() == resppreg2)
                {
                    reg.Resp2 = "Correcta";
                }
                else
                {
                    reg.Resp2 = "Incorrecta";
                }
            }
            else if (rdbres3preg2.Checked == true)
            {
                if (rdbres3preg2.Text.TrimEnd() == resppreg2)
                {
                    reg.Resp2 = "Correcta";
                }
                else
                {
                    reg.Resp2 = "Incorrecta";
                }
            }
            else if (rdbres4preg2.Checked == true)
            {
                if (rdbres4preg2.Text.TrimEnd() == resppreg2)
                {
                    reg.Resp2 = "Correcta";
                }
                else
                {
                    reg.Resp2 = "Incorrecta";
                }
            }

            if (rdbres1preg3.Checked == true)
            {
                if (rdbres1preg3.Text.TrimEnd() == resppreg3)
                {
                    reg.Resp3 = "Correcta";
                }
                else
                {
                    reg.Resp3 = "Incorrecta";
                }
            }
            else if (rdbres2preg3.Checked == true)
            {
                if (rdbres2preg3.Text.TrimEnd() == resppreg3)
                {
                    reg.Resp3 = "Correcta";
                }
                else
                {
                    reg.Resp3 = "Incorrecta";
                }
            }
            else if (rdbres3preg3.Checked == true)
            {
                if (rdbres3preg3.Text.TrimEnd() == resppreg3)
                {
                    reg.Resp3 = "Correcta";
                }
                else
                {
                    reg.Resp3 = "Incorrecta";
                }
            }
            else if (rdbres4preg3.Checked == true)
            {
                if (rdbres4preg3.Text.TrimEnd() == resppreg3)
                {
                    reg.Resp3 = "Correcta";
                }
                else
                {
                    reg.Resp3 = "Incorrecta";
                }
            }

            if (rdbres1preg4.Checked == true)
            {
                if (rdbres1preg4.Text.TrimEnd() == resppreg4)
                {
                    reg.Resp4 = "Correcta";
                }
                else
                {
                    reg.Resp4 = "Incorrecta";
                }
            }
            else if (rdbres2preg4.Checked == true)
            {
                if (rdbres2preg4.Text.TrimEnd() == resppreg4)
                {
                    reg.Resp4 = "Correcta";
                }
                else
                {
                    reg.Resp4 = "Incorrecta";
                }
            }
            else if (rdbres3preg4.Checked == true)
            {
                if (rdbres3preg4.Text.TrimEnd() == resppreg4)
                {
                    reg.Resp4 = "Correcta";
                }
                else
                {
                    reg.Resp4 = "Incorrecta";
                }
            }
            else if (rdbres4preg4.Checked == true)
            {
                if (rdbres4preg4.Text.TrimEnd() == resppreg4)
                {
                    reg.Resp4 = "Correcta";
                }
                else
                {
                    reg.Resp4 = "Incorrecta";
                }
            }

            if (rdbres1preg5.Checked == true)
            {
                if (rdbres1preg5.Text.TrimEnd() == resppreg5)
                {
                    reg.Resp5 = "Correcta";
                }
                else
                {
                    reg.Resp5 = "Incorrecta";
                }
            }
            else if (rdbres2preg5.Checked == true)
            {
                if (rdbres2preg5.Text.TrimEnd() == resppreg5)
                {
                    reg.Resp5 = "Correcta";
                }
                else
                {
                    reg.Resp5 = "Incorrecta";
                }
            }
            else if (rdbres3preg5.Checked == true)
            {
                if (rdbres3preg5.Text.TrimEnd() == resppreg5)
                {
                    reg.Resp5 = "Correcta";
                }
                else
                {
                    reg.Resp5 = "Incorrecta";
                }
            }
            else if (rdbres4preg5.Checked == true)
            {
                if (rdbres4preg5.Text.TrimEnd() == resppreg5)
                {
                    reg.Resp5 = "Correcta";
                }
                else
                {
                    reg.Resp5 = "Incorrecta";
                }
            }
        }
    }
}