using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_web.Data_access
{
    public partial class Prueba : System.Web.UI.Page
    {
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
            Response.Redirect("Prueba rápida2.aspx");
        }
    }
}