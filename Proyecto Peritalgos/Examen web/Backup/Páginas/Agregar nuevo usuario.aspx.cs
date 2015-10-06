using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_web.Data_access;

namespace Examen_web.Páginas
{
    public partial class Agregar_nuevo_usuario : System.Web.UI.Page
    {
        SQL_usuarios agregar = new SQL_usuarios();
        ExamEncryptor encr = new ExamEncryptor();
        
        protected void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcontraseña1.Text == txtcontraseña2.Text && txtnombre.Text != "" && txtcontraseña1.Text != "")
            {
                agregar.Nombre_usuario = txtnombre.Text;
                agregar.Contraseña = encr.EncryptDecryptText('S',txtcontraseña1.Text);
                agregar.Tipo_de_usuario = ddlnivel.SelectedValue;
                agregar.Seccion = ddlesp_sec.SelectedItem.Text;

                agregar.Agregar();

                Response.Redirect("LogIn.aspx");
            }
            else
            {
                txtcontraseña1.BackColor = System.Drawing.Color.Red;
                txtcontraseña2.BackColor = System.Drawing.Color.Red;

                lblerror.Visible = true;
                lblerror.Text = "Las contraseñas no coinciden o hay datos incompletos";
            }
        }

        protected void ddlnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlnivel.SelectedValue == "03")
            {
                Label1.Text = "Sección:";
                ddlesp_sec.Items.Clear();

                for (int i = 1; i <= 3; i++)
                {
                    ddlesp_sec.Items.Add("12-" + i);
                    ddlesp_sec.Items.Add("11-" + i);
                    ddlesp_sec.Items.Add("10-" + i);
                }
            }
            else
            {
                Label1.Text = "Especialidad:";
                ddlesp_sec.Items.Clear();
                ddlesp_sec.Items.Add("Contabilidad");
                ddlesp_sec.Items.Add("Informatica");
                ddlesp_sec.Items.Add("Ejectivo");
            }
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }
    }
}