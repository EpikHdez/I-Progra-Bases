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

public partial class insertarSancion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregarSancion_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-OH9K9VP;Initial Catalog=CampeonatosDB;Integrated Security=True"))
        {
            using (SqlCommand agregarSancion = new SqlCommand("CASP_InsertarSancion", con))
            {
                agregarSancion.CommandType = System.Data.CommandType.StoredProcedure;
                agregarSancion.Parameters.Add("@pPuntos", System.Data.SqlDbType.Int).Value = txtPuntosAgregarSancion.Text;
                agregarSancion.Parameters.Add("@pCarrera", System.Data.SqlDbType.Int).Value = Session["carreraActual"].ToString();
                agregarSancion.Parameters.Add("@pTipoSancion", System.Data.SqlDbType.Int).Value = txtSancionAgregarSancion.Text;
                agregarSancion.Parameters.Add("@pTipoMovimientoSancion", System.Data.SqlDbType.Int).Value = txtTipoMovimientoSancion.Text;
                agregarSancion.Parameters.Add("@pNumeroCorredor", System.Data.SqlDbType.Int).Value = txtNumeroCorredor.Text;
                agregarSancion.Parameters.Add("@pPostIn", System.Data.SqlDbType.VarChar).Value = HttpContext.Current.Request.UserHostAddress;
                agregarSancion.Parameters.Add("@pPostBy", System.Data.SqlDbType.VarChar).Value = Session["usuarioActual"].ToString();

                con.Open();

                agregarSancion.ExecuteNonQuery();

                con.Close();

                Response.Redirect("menuSancion.aspx");
            }
        }
    }
}