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

public partial class insertarTipoMovimientoSancion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertarTipoMovimientoSancion_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand insertarTipoMovimientoSancion = new SqlCommand("CASP_InsertarTipoMovimientoSancion", con))
            {
                insertarTipoMovimientoSancion.CommandType = System.Data.CommandType.StoredProcedure;
                insertarTipoMovimientoSancion.Parameters.Add("@pNombre", System.Data.SqlDbType.VarChar).Value = txtNombre.Text;

                con.Open();

                insertarTipoMovimientoSancion.ExecuteNonQuery();

                con.Close();

                Response.Redirect("menuTipoMovimientoSancion.aspx");
            }
        }
    }
}