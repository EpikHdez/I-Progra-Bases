using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insertarTipoSancion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void botonCrearTipoSancion_Click(object sender, EventArgs e)
    {
        string nombre = txtNombreTipoSancion.Text;
        lblSancion.Text = nombre;       
               
    }
}