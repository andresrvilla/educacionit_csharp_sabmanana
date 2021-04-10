using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Administracion.Comentarios
{
    public partial class Default : System.Web.UI.Page
    {
        private ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                lstComentarios.DataSource = comentarioNegocio.TodosLosComentarios();
                lstComentarios.DataBind();
            }
        }
    }
}