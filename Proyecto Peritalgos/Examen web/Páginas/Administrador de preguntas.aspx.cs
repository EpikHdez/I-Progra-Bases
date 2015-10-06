using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Examen_web.Páginas
{
    public partial class Administrador_de_preguntas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int a;
            for (a = 1; a <= 75; a++)
            {
                ddl_numpreg.Items.Add(a.ToString());
            }

            
        }

        protected void ddl_numpreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQL_conection.numpreg = ddl_numpreg.SelectedItem.Text;
            FileUploadControl.Visible = false;
            UploadButton.Visible = false;
            btn_guardar.Visible = false;
            btn_editar.Visible = true;
            txt_respuesta.ReadOnly = true;
            txt_pregunta.ReadOnly = true;
            txt_op4.ReadOnly = true;
            txt_op3.ReadOnly = true;
            txt_op2.ReadOnly = true;
            txt_op1.ReadOnly = true;

            llenado();
        }

        public void llenado()
        {
            SQL_conection sqlpre = new SQL_conection();
            sqlpre.JalarPregFilter();

            lbl_imagen.Visible = true;
            ib_preg.Visible = true;
            //ib_preg.ImageUrl = sqlpre.Img.TrimEnd();
            ib_preg.ImageUrl = ("~/ImagenesDePreguntas/" + SQL_conection.numpreg + ".jpg");
            lbl_pregunta.Visible = true;
            txt_pregunta.Text = sqlpre.Preg1.TrimEnd();
            txt_pregunta.Visible = true;
            lbl_opcion1.Visible = true;
            txt_op1.Text = sqlpre.Op1.TrimEnd();
            txt_op1.Visible = true;
            lbl_opcion2.Visible = true;
            txt_op2.Text = sqlpre.Op2.TrimEnd();
            txt_op2.Visible = true;
            lbl_opcion3.Visible = true;
            txt_op3.Text = sqlpre.Op3.TrimEnd();
            txt_op3.Visible = true;
            lbl_opcion4.Visible = true;
            txt_op4.Text = sqlpre.Op4.TrimEnd();
            txt_op4.Visible = true;
            lbl_respuesta.Visible = true;
            txt_respuesta.Text = sqlpre.Resp.TrimEnd();
            txt_respuesta.Visible = true;
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        public void guardado()
        {
            SQL_conection sqlpre = new SQL_conection();
            sqlpre.Preg1 = txt_pregunta.Text;
            sqlpre.Op1 = txt_op1.Text;
            sqlpre.Op2 = txt_op2.Text;
            sqlpre.Op3 = txt_op3.Text;
            sqlpre.Op4 = txt_op4.Text;
            sqlpre.Resp = txt_respuesta.Text;
            
            sqlpre.JalarPregFilter();

        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            txt_pregunta.ReadOnly = false;
            txt_op1.ReadOnly = false;
            txt_op2.ReadOnly = false;
            txt_op3.ReadOnly = false;
            txt_op4.ReadOnly = false;
            txt_respuesta.ReadOnly = false;
            btn_editar.Visible = false;
            btn_guardar.Visible = true;
            ib_preg.Visible = false;

            UploadButton.Visible = true;
            
            FileUploadControl.Visible = true;

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                try
                {
                    FileUploadControl.SaveAs(Server.MapPath("~/ImagenesDePreguntas/") + ddl_numpreg.SelectedItem.Text + ".jpg");                   
                }
                catch
                {
                    throw;
                }
            }
        }

        protected void btn_atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menú profesor.aspx");
        }
    }
}