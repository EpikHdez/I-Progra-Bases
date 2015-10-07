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

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand validarLogin = new SqlCommand("CASP_VerificarLogIn", con))
            {
                validarLogin.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter resultado = new SqlParameter("@return", SqlDbType.Int);
                resultado.Direction = ParameterDirection.Output;
                validarLogin.Parameters.Add(resultado);
                validarLogin.Parameters.Add("@pUserName", System.Data.SqlDbType.VarChar).Value = txtUserName.Text;

                con.Open();
                validarLogin.ExecuteNonQuery();

                con.Close();

                int res = (int)validarLogin.Parameters["@return"].Value;
                lbl_error.Text = res.ToString();

                if (res == 1)
                {
                    Response.Redirect("index.aspx");
                }
                else if(res == -1)
                {
                    Response.Redirect("insertarCarrera.aspx");
                }
            }
        }
    }
}