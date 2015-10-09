using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btningresar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand validarLogin = new SqlCommand("CASP_VerificarLogIn", con))
            {
                validarLogin.CommandType = System.Data.CommandType.StoredProcedure;
                Session["usuarioActual"] = txtUserName.Text;

                validarLogin.Parameters.Add("@pUserName", System.Data.SqlDbType.VarChar).Value = Session["usuarioActual"].ToString();

                con.Open();
                int res = (int)validarLogin.ExecuteScalar();

                con.Close();

                if (res == 1)
                {
                    Session["tipoUsuario"] = res.ToString();
                    Response.Redirect("index.aspx");
                }
                else if(res == 2)
                {
                    Session["tipoUsuario"] = res.ToString();
                    Response.Redirect("index.aspx");
                }
                else if(res == -1)
                {
                    lbl_error.Text = "Error en el login, verifique los datos";
                    lbl_error.Visible = true;
                }
            }
        }
    }
}