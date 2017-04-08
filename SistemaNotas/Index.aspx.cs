using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaNotas
{
    public partial class _Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn(object sender, EventArgs e)
        {
            Response.Redirect("MantenedorPerfiles.aspx");
        }

        protected void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar.aspx");
        }
    }
}