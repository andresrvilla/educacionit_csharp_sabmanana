using Entidades;
using EntidadesEF;
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

        private ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                string elId = Request.QueryString["id"];
                int id = Convert.ToInt32(elId);

                PostEntidad unPost = postNegocio.ObtenerPost(id);
                lblTitulo.Text = unPost.Titulo;
                lblContenido.Text = unPost.Cuerpo;

                lstComentarios.DataSource = comentarioNegocio.TodosLosComentarios(id);
                lstComentarios.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string elId = Request.QueryString["id"];
            int id = Convert.ToInt32(elId);

            Comentario nuevoComentario = new Comentario()
            {
                Autor = txtAutor.Text,
                Comentario1 = txtComentario.Text,
                IdPost = id
            };

            comentarioNegocio.CrearComentario(nuevoComentario);

            lstComentarios.DataSource = comentarioNegocio.TodosLosComentarios(id);
            lstComentarios.DataBind();
        }
    }
}