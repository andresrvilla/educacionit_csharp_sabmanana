using EntidadesEF;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Administracion.Comentarios
{
    public partial class Eliminar : System.Web.UI.Page
    {
        ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string valorId = Request.QueryString["id"];
                int id = Convert.ToInt32(valorId);

                Comentario elComentario = comentarioNegocio.ObtenerUnComentario(id);
                lblComentario.Text = elComentario.Comentario1;
                lblAutor.Text = elComentario.Autor;
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string valorId = Request.QueryString["id"];
            int id = Convert.ToInt32(valorId);
            comentarioNegocio.BorrarComentario(id);

            Response.Redirect("~/Administracion/Comentarios");

            //Esta otra redireccion cambia la visualizacion pero no la url del navegador
            //Server.Transfer("~/Administracion/Comentarios/Default.aspx");
        }
    }
}