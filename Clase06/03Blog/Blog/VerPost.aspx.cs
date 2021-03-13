using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class VerPost : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                string elId = Request.QueryString["id"];
                int id = Convert.ToInt32(elId);

                PostEntidad unPost = postNegocio.ObtenerPost(id);
                lblTitulo.Text = unPost.Titulo;
                lblContenido.Text = unPost.Cuerpo;
            }
        }
    }
}