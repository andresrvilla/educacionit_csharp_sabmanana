using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class ContadorViewState : System.Web.UI.Page
    {
        private int contador = 0;

        private const string CLAVE_VIEWSTATE = "Contador";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                contador = (int)ViewState[CLAVE_VIEWSTATE];
            }
            else
            {
                ViewState[CLAVE_VIEWSTATE] = 0;
            }
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            ViewState[CLAVE_VIEWSTATE] = contador;
            lblContador.Text = contador.ToString();
        }
    }
}