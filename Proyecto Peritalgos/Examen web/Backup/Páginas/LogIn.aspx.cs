using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenWeb.Pages;
using Examen_web.Data_access;

namespace ExamenWeb.Pages
{
    public partial class LogIn : System.Web.UI.Page
    {
        ExamEncryptor encr = new ExamEncryptor();
        public static string tipo_usu;

        protected void imgbtn_Click(object sender, ImageClickEventArgs e)
        {
            SQL_usuarios usu = new SQL_usuarios();
            SQL_registro reg = new SQL_registro();

            usu.JalarUsuarios(txtUserName.Text.TrimEnd(), encr.EncryptDecryptText('S', txtPassword.Text)); //Esto es un login! XD
            
            if (SQL_usuarios.contrajalada != null) //No se si esto es bueno jajaja, creo que si... XD
            {
                string a = encr.EncryptDecryptText('A', SQL_usuarios.contrajalada);
                if (txtUserName.Text.TrimEnd() == usu.Nombre_usuario.TrimEnd())
                {
                    if (usu.Tipo_de_usuario.Trim() == "03")
                    {
                        SQL_registro.nom = usu.Nombre_usuario.TrimEnd();
                        SQL_registro.sec = usu.Seccion.TrimEnd();
                        tipo_usu = "03";
                        Response.Redirect("Menú estudiante.aspx");

                    }
                    else if (usu.Tipo_de_usuario.Trim() == "02")
                    {
                        SQL_registro.nom = usu.Nombre_usuario.TrimEnd();
                        SQL_registro.sec = usu.Seccion.TrimEnd();
                        tipo_usu = "02";
                        Response.Redirect("Menú profesor.aspx");
                    }
                    else
                    {
                        SQL_registro.nom = usu.Nombre_usuario.TrimEnd();
                        SQL_registro.sec = usu.Seccion.TrimEnd();
                        tipo_usu = "01";
                        Response.Redirect("Menú profesor.aspx");
                    }
                }
                else
                {
                    lbl_error.Visible = true;
                }
            }
            else
            {
                lbl_error.Visible = true;
            }
        }
        protected void btnagregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar nuevo usuario.aspx");
        }

    }
}