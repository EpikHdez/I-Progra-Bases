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
        public static string resppreg6, resppreg7, resppreg8, resppreg9, resppreg10;

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
            resppreg6 = nva.Resp.TrimEnd();

            nva.JalarPreg7();

            lblpregunta7.Text = nva.Preg1;
            rdbres1preg7.Text = nva.Op1;
            rdbres2preg7.Text = nva.Op2;
            rdbres3preg7.Text = nva.Op3;
            rdbres4preg7.Text = nva.Op4;
            resppreg7 = nva.Resp.TrimEnd();

            nva.JalarPreg8();

            lblpregunta8.Text = nva.Preg1;
            rdbres1preg8.Text = nva.Op1;
            rdbres2preg8.Text = nva.Op2;
            rdbres3preg8.Text = nva.Op3;
            rdbres4preg8.Text = nva.Op4;
            resppreg8 = nva.Resp.TrimEnd();

            nva.JalarPreg9();

            lblpregunta9.Text = nva.Preg1;
            rdbres1preg9.Text = nva.Op1;
            rdbres2preg9.Text = nva.Op2;
            rdbres3preg9.Text = nva.Op3;
            rdbres4preg9.Text = nva.Op4;
            resppreg9 = nva.Resp.TrimEnd();

            nva.JalarPreg10();

            lblpregunta10.Text = nva.Preg1;
            rdbres1preg10.Text = nva.Op1;
            rdbres2preg10.Text = nva.Op2;
            rdbres3preg10.Text = nva.Op3;
            rdbres4preg10.Text = nva.Op4;
            resppreg10 = nva.Resp.TrimEnd();

        }

        protected void Tiempo_Tick(object sender, EventArgs e)
        {
            Prueba_rápida.seg = Prueba_rápida.seg - 1;
            txtseg.Text = Prueba_rápida.seg.ToString();

            if (Prueba_rápida.seg == 0)
            {
                Prueba_rápida.min = Prueba_rápida.min - 1;
                txtmin.Text = Prueba_rápida.min.ToString();
                Prueba_rápida.seg = 59;
                txtseg.Text = Prueba_rápida.seg.ToString();

                if (Prueba_rápida.min == 0)
                {
                    Prueba_rápida.min = 59;
                    txtmin.Text = Prueba_rápida.min.ToString();

                    if (Prueba_rápida.horas != 0)
                    {
                        Prueba_rápida.horas = Prueba_rápida.horas - 1;
                        txthoras.Text = Prueba_rápida.horas.ToString();
                    }
                }
            }
        }


        protected void btn_calificar_Click(object sender, EventArgs e)
        {
            guardado();
            Response.Redirect("Calificar prueba rapida.aspx");
        }

        public void guardado()
        {
            SQL_registro reg = new SQL_registro();

            if (rdbres1preg6.Checked == true)
            {
                if (rdbres1preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }
            else if (rdbres2preg6.Checked == true)
            {
                if (rdbres2preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }
            else if (rdbres3preg6.Checked == true)
            {
                if (rdbres3preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }
            else if (rdbres4preg6.Checked == true)
            {
                if (rdbres4preg6.Text.TrimEnd() == resppreg6)
                {
                    reg.Resp6 = "Correcta";
                }
                else
                {
                    reg.Resp6 = "Incorrecta";
                }
            }


            if (rdbres1preg7.Checked == true)
            {
                if (rdbres1preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }
            else if (rdbres2preg7.Checked == true)
            {
                if (rdbres2preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }
            else if (rdbres3preg7.Checked == true)
            {
                if (rdbres3preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }
            else if (rdbres4preg7.Checked == true)
            {
                if (rdbres4preg7.Text.TrimEnd() == resppreg7)
                {
                    reg.Resp7 = "Correcta";
                }
                else
                {
                    reg.Resp7 = "Incorrecta";
                }
            }

            if (rdbres1preg8.Checked == true)
            {
                if (rdbres1preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }
            else if (rdbres2preg8.Checked == true)
            {
                if (rdbres2preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }
            else if (rdbres3preg8.Checked == true)
            {
                if (rdbres3preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }
            else if (rdbres4preg8.Checked == true)
            {
                if (rdbres4preg8.Text.TrimEnd() == resppreg8)
                {
                    reg.Resp8 = "Correcta";
                }
                else
                {
                    reg.Resp8 = "Incorrecta";
                }
            }

            if (rdbres1preg9.Checked == true)
            {
                if (rdbres1preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }
            else if (rdbres2preg9.Checked == true)
            {
                if (rdbres2preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }
            else if (rdbres3preg9.Checked == true)
            {
                if (rdbres3preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }
            else if (rdbres4preg9.Checked == true)
            {
                if (rdbres4preg9.Text.TrimEnd() == resppreg9)
                {
                    reg.Resp9 = "Correcta";
                }
                else
                {
                    reg.Resp9 = "Incorrecta";
                }
            }

            if (rdbres1preg10.Checked == true)
            {
                if (rdbres1preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
            else if (rdbres2preg10.Checked == true)
            {
                if (rdbres2preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
            else if (rdbres3preg10.Checked == true)
            {
                if (rdbres3preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
            else if (rdbres4preg10.Checked == true)
            {
                if (rdbres4preg10.Text.TrimEnd() == resppreg10)
                {
                    reg.Resp10 = "Correcta";
                }
                else
                {
                    reg.Resp10 = "Incorrecta";
                }
            }
        }
    }
}