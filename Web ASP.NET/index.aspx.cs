using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    int tipo;
    protected void Page_Load(object sender, EventArgs e)
    { 
        tipo = Convert.ToInt32(Request.QueryString["tipo"]);
        if(tipo == 1)
        {
            btnMenuCatalogos.Enabled = false;
        }
    }

    protected void btnMenuCampeonato_Click(object sender, EventArgs e)
    {
        if(Convert.ToInt32(Session["tipoUsuario"]) == 1)
        {
            Response.Redirect("menuCampeonato.aspx");
        }
        else if(Convert.ToInt32(Session["tipoUsuario"]) == 2)
        {
            Response.Redirect("menuCampeonato.aspx");
        }
    }

    protected void btnMenuCatalogos_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuCatalogo.aspx");
    }
}