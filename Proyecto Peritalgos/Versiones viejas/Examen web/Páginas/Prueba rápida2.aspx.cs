using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;
using Examen_web.Páginas;

namespace Examen_web.Páginas
{
    public partial class Prueba_rápida2 : System.Web.UI.Page
    {
        public int horas, min, seg;

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
    }
}