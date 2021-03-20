using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class ContadorAplicacion : System.Web.UI.Page
    {
        private const string CLAVE_APLICACION = "Contador";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblContador.Text = Application[CLAVE_APLICACION].ToString();
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            int valor = (int)Application[CLAVE_APLICACION];
            valor++;
            Application[CLAVE_APLICACION] = valor;
            lblContador.Text = valor.ToString();
        }
    }
}