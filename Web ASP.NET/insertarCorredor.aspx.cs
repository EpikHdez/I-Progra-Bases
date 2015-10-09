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

public partial class insertarCorredor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertarCorredor_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Data Source = DESKTOP-OH9K9VP; Initial Catalog = CampeonatosDB; Integrated Security = True"))
        {
            using (SqlCommand insertarCorredor = new SqlCommand("CASP_InsertarCorredor", con))
            {
                insertarCorredor.CommandType = System.Data.CommandType.StoredProcedure;
                insertarCorredor.Parameters.Add("@pIdentificacion", System.Data.SqlDbType.Int).Value = txtIdentificacionInsertarCorredor.Text;
                insertarCorredor.Parameters.Add("@pNombre", System.Data.SqlDbType.VarChar).Value = txtNombreInsertarCorredor.Text;
                insertarCorredor.Parameters.Add("@pAlias", System.Data.SqlDbType.VarChar).Value = txtAliasInsertarCorredor.Text;
                insertarCorredor.Parameters.Add("@pEmail", System.Data.SqlDbType.VarChar).Value = txtEmailInsertarCorredor.Text;
                insertarCorredor.Parameters.Add("@pGenero", System.Data.SqlDbType.VarChar).Value = txtGeneroInsertarCorredor.Text;
                insertarCorredor.Parameters.Add("@pFechaNacimiento", System.Data.SqlDbType.Date).Value = txtFechaInsertarCorredor.Text;
                insertarCorredor.Parameters.Add("@IDCampeonato", System.Data.SqlDbType.Int).Value = Session["campeonatoActual"].ToString();

                con.Open();

                insertarCorredor.ExecuteNonQuery();

                con.Close();

                Response.Redirect("menuCorredor.aspx");
            }
        }
    }
}