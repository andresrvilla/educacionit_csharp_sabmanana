using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class ContadorSesion : System.Web.UI.Page
    {

        private const string CLAVE_SESION = "Contador";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session[CLAVE_SESION] == null)
            {
                Session[CLAVE_SESION] = 0;
            }
            else
            {
                lblContador.Text = Session[CLAVE_SESION].ToString();
            }
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            int valor = (int)Session[CLAVE_SESION];
            valor++;
            Session[CLAVE_SESION] = valor;
            lblContador.Text = valor.ToString();
        }
    }
}