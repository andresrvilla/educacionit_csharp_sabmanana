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
    public partial class Default : System.Web.UI.Page
    {
        PostNegocio negocio = new PostNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<PostEntidad> todosLosPost = negocio.TodosLosPosts();
            lstPosteos.DataSource = todosLosPost;
            lstPosteos.DataBind();
        }
    }
}