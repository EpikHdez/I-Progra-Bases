using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menuCatalogo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void menuTipoMovimientoSancion_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuTipoMovimientoSancion.aspx");
    }

    protected void menuTipoMovimientoPuntos_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuTipoMovimientoPuntos.aspx");
    }

    protected void menuTipoSancion_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuTipoSancion.aspx");
    }
}