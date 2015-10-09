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

public partial class insertarTipoSancion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void botonCrearTipoSancion_Click(object sender, EventArgs e)
    {  
        using(SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand insertarTipoSancion = new SqlCommand("CASP_InsertarTipoSancion", con))
            {
                insertarTipoSancion.CommandType = System.Data.CommandType.StoredProcedure;
                insertarTipoSancion.Parameters.Add("@pNombre", System.Data.SqlDbType.VarChar).Value = txtNombreTipoSancion.Text;

                con.Open();

                insertarTipoSancion.ExecuteNonQuery();

                con.Close();

                Response.Redirect("menuTipoSancion.aspx");
            }
        }             
    }
}