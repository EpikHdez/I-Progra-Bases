using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menuCampeonato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMenuCarrerasCampeonato_Click(object sender, EventArgs e)
    {
        if(GridView1.SelectedDataKey.Value != null)
        {
            Session["campeonatoActual"] = Int32.Parse(GridView1.SelectedDataKey.Value.ToString());

            Response.Redirect("menuCarrera.aspx");
        }

        else
        {
            Label1.Visible = true;
        }      
    }

    protected void btnMenuCorredoresCampeonato_Click(object sender, EventArgs e)
    {
        if(GridView1.SelectedDataKey.Value != null)
        {
            Session["campeonatoActual"] = Int32.Parse(GridView1.SelectedDataKey.Value.ToString());

            Response.Redirect("menuCorredor.aspx");
        }
    }
}