using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string saludo = $"Hola {nombre}";
            lblSaludo.Text = saludo;
        }
    }
}