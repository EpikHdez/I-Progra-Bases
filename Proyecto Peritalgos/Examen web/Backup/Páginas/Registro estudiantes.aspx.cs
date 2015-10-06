using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Registro_estudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                ddl_seccion.Items.Add("12-" + i);
                ddl_seccion.Items.Add("11-" + i);
                ddl_seccion.Items.Add("10-" + i);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        public void busqueda()
        {
            pnl_registro.Visible = true;

            SQL_registro sql = new SQL_registro();
            sql.Nom_usu1 = txt_nombre.Text.TrimEnd();
            sql.Seccion = ddl_seccion.SelectedItem.Text.TrimEnd();
            sql.JalarUsuarios();

            lbl_nombre.Text = sql.Nom_usu1;
            lbl_seccion.Text = sql.Seccion;
            lbl_preg1.Text = sql.Resp1;
            lbl_preg2.Text = sql.Resp2;
            lbl_preg3.Text = sql.Resp3;
            lbl_preg4.Text = sql.Resp4;
            lbl_preg5.Text = sql.Resp5;
            lbl_preg6.Text = sql.Resp6;
            lbl_preg7.Text = sql.Resp7;
            lbl_preg8.Text = sql.Resp8;
            lbl_preg9.Text = sql.Resp9;
            lbl_preg10.Text = sql.Resp10;
            lbl_preg11.Text = sql.Resp11;
            lbl_preg12.Text = sql.Resp12;
            lbl_preg13.Text = sql.Resp13;
            lbl_preg14.Text = sql.Resp14;
            lbl_preg15.Text = sql.Resp15;
            lbl_preg16.Text = sql.Resp16;
            lbl_preg17.Text = sql.Resp17;
            lbl_preg18.Text = sql.Resp18;
            lbl_preg19.Text = sql.Resp19;
            lbl_preg20.Text = sql.Resp20;

            lbl_preg21.Text = sql.Resp21;
            lbl_preg22.Text = sql.Resp22;
            lbl_preg23.Text = sql.Resp23;
            lbl_preg24.Text = sql.Resp24;
            lbl_preg25.Text = sql.Resp25;
            lbl_preg26.Text = sql.Resp26;
            lbl_preg27.Text = sql.Resp27;
            lbl_preg28.Text = sql.Resp28;
            lbl_preg29.Text = sql.Resp29;
            lbl_preg30.Text = sql.Resp30;
            lbl_preg31.Text = sql.Resp31;
            lbl_preg32.Text = sql.Resp32;
            lbl_preg33.Text = sql.Resp33;
            lbl_preg34.Text = sql.Resp34;
            lbl_preg35.Text = sql.Resp35;
            lbl_preg36.Text = sql.Resp36;
            lbl_preg37.Text = sql.Resp37;
            lbl_preg38.Text = sql.Resp38;
            lbl_preg39.Text = sql.Resp39;
            lbl_preg40.Text = sql.Resp40;

            lbl_preg41.Text = sql.Resp41;
            lbl_preg42.Text = sql.Resp42;
            lbl_preg43.Text = sql.Resp43;
            lbl_preg44.Text = sql.Resp44;
            lbl_preg45.Text = sql.Resp45;
            lbl_preg46.Text = sql.Resp46;
            lbl_preg47.Text = sql.Resp47;
            lbl_preg48.Text = sql.Resp48;
            lbl_preg49.Text = sql.Resp49;
            lbl_preg50.Text = sql.Resp50;
            lbl_preg51.Text = sql.Resp51;
            lbl_preg52.Text = sql.Resp52;
            lbl_preg53.Text = sql.Resp53;
            lbl_preg54.Text = sql.Resp54;
            lbl_preg55.Text = sql.Resp55;
            lbl_preg56.Text = sql.Resp56;
            lbl_preg57.Text = sql.Resp57;
            lbl_preg58.Text = sql.Resp58;
            lbl_preg59.Text = sql.Resp59;
            lbl_preg60.Text = sql.Resp60;

            lbl_preg61.Text = sql.Resp61;
            lbl_preg62.Text = sql.Resp62;
            lbl_preg63.Text = sql.Resp63;
            lbl_preg64.Text = sql.Resp64;
            lbl_preg65.Text = sql.Resp65;
            lbl_preg66.Text = sql.Resp66;
            lbl_preg67.Text = sql.Resp67;
            lbl_preg68.Text = sql.Resp68;
            lbl_preg69.Text = sql.Resp69;
            lbl_preg70.Text = sql.Resp70;
            lbl_preg71.Text = sql.Resp71;
            lbl_preg72.Text = sql.Resp72;
            lbl_preg73.Text = sql.Resp73;
            lbl_preg74.Text = sql.Resp74;
            lbl_preg75.Text = sql.Resp75;
        }

        protected void btn_atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menú profesor.aspx");
        }
    }
}