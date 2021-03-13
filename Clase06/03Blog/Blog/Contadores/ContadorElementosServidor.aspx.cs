using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class ContadorElementosServidor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(lblContador.Text);
            valor++;
            lblContador.Text = valor.ToString();
        }
    }
}