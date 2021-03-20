using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.MasterPages
{
    public partial class Sitio : System.Web.UI.MasterPage
    {
        private const string CLAVE = "Fecha";
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Request: Simboliza los datos que llegan DESDE el cliente (navegador)
             * Response: Simboliza los datos que se enviaran como respuesta al cliente
             */

            if(Request.Cookies[CLAVE] == null || string.IsNullOrWhiteSpace(Request.Cookies[CLAVE].Value))
            {
                Response.Cookies[CLAVE].Value = DateTime.Now.ToString();
                Response.Cookies[CLAVE].Expires = DateTime.Now.AddDays(1);
            }

            lblUltimoUso.Text = Request.Cookies[CLAVE].Value;

            //Leer de la configuración el titulo del blog
            string nombre = ConfigurationManager.AppSettings["NombreBlog"] ?? "Blog";
            lblMarca.Text = nombre;
            lblMarcaTitulo.Text = nombre;
        }
    }
}