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
        public int horas, min, seg;
        public string preg1 { get; set; } 
        public string preg2, preg3, preg4, preg5;

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
            nva.Jalar();

            lblpregunta1.Text = nva.Jalar();
            chkres1preg1.Text = nva.Jalar();
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

                if (min == 0)
                {
                    min = 59;
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