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

public partial class insertarTipoMovimientoPuntos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertarMovimientoPuntos_Click(object sender, EventArgs e)
    {
        using(SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand insertarTipoMovimiento = new SqlCommand("CASP_InsertarTipoMovimientoPuntos", con))
            {
                insertarTipoMovimiento.CommandType = System.Data.CommandType.StoredProcedure;
                insertarTipoMovimiento.Parameters.Add("@pNombre", System.Data.SqlDbType.VarChar).Value = txtNombre.Text;

                con.Open();

                insertarTipoMovimiento.ExecuteNonQuery();

                con.Close();

                Response.Redirect("menuTipoMovimientoPuntos.aspx");
            }
        }
    }
}