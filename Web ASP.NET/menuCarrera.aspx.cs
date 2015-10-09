using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menuCarrera : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertarCarrera_Click(object sender, EventArgs e)
    { 
        Response.Redirect("insertarCarrera.aspx");
    }

    protected void btnInsertarSancion_Click(object sender, EventArgs e)
    {
        if (GridView1.SelectedDataKey.Value != null)
        {
            Session["carreraActual"] = Int32.Parse(GridView1.SelectedDataKey.Value.ToString());

            Response.Redirect("menuSancion.aspx");
        }
    }
}