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

public partial class insertarCarrera : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnAgregarCarreraCampeonato_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand agregarCarrera = new SqlCommand("CASP_InsertarCarrera", con))
            {
                agregarCarrera.CommandType = System.Data.CommandType.StoredProcedure;
                agregarCarrera.Parameters.Add("@pDescripcion", System.Data.SqlDbType.VarChar).Value = txtDescripcionAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pLugarPartida", System.Data.SqlDbType.VarChar).Value = txtLugarPartidaAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pLugarLlegada", System.Data.SqlDbType.VarChar).Value = txtlugarLlegadaAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pRecorrido", System.Data.SqlDbType.VarChar).Value = txtRecorridoAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pFecha", System.Data.SqlDbType.Date).Value = txtFechaAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pHora", System.Data.SqlDbType.Time).Value = txtHoraAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pCosto", System.Data.SqlDbType.Int).Value = txtCostoAgregarCarrera.Text;
                agregarCarrera.Parameters.Add("@pCampeonato", System.Data.SqlDbType.Int).Value = Session["campeonatoActual"].ToString();

                con.Open();

                agregarCarrera.ExecuteNonQuery();

                con.Close();

                Response.Redirect("menuCarrera.aspx");         

            }
        }
    }
}