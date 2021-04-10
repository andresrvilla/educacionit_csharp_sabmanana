using Entidades;
using Entidades.Exceptions;
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
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Aca faltaria el tratamiento de errores
            List<CategoriaEntidad> categorias = categoriaNegocio.ObtenerTodasLasCategorias();
            cmbCategorias.DataSource = categorias;
            cmbCategorias.DataBind();


            try
            {
                List<PostEntidad> todosLosPost = negocio.TodosLosPosts();
                lstPosteos.DataSource = todosLosPost;
                lstPosteos.DataBind();
            }
            catch(CapaDeDatosException ex)
            {
                lblError.Text = "Ha ocurrido un error al obtener los datos de los posts: "+ex.Message;
                pnlErrorPosts.Visible = true;
            }
            catch
            {

            }
            finally
            {
                //Se ejecuta haya habido o no un error
            }

        }

        protected void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = cmbCategorias.SelectedValue;
            int id = Convert.ToInt32(valorSeleccionado);
            //Puedo buscar las subCategorias
            //Aca voy a poner de ejemplo que cargue el segundo combo con categorias
            //Pero se debería reemplazar por la lectura de subcategorias
            //desde la base de datos con el id obtenido

            List<CategoriaEntidad> subCategorias = new List<CategoriaEntidad>()
            {
                new CategoriaEntidad(){ Id=1,Nombre="Sub Categoria 1" },
                new CategoriaEntidad(){ Id=2,Nombre="Sub Categoria 2" },
                new CategoriaEntidad(){ Id=3,Nombre="Sub Categoria 3" }
            };

            cmbSubCategorias.DataSource = subCategorias;
            cmbSubCategorias.DataBind();
        }
    }
}