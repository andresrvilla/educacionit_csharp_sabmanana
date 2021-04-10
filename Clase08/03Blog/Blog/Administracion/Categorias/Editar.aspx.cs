using Entidades;
using Entidades.Exceptions;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Administracion.Categorias
{
    public partial class Editar : System.Web.UI.Page
    {
        private CategoriaNegocio categoriasNegocio = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                string idParametro = Request.QueryString["id"];
                if (string.IsNullOrWhiteSpace(idParametro) == false)
                {
                    /*
                     Estoy en modo edicion porque
                    llego un id
                     */
                    int id = Convert.ToInt32(idParametro);
                    CategoriaEntidad categoria = categoriasNegocio.ObtenerCategoria(id);
                    txtNombre.Text = categoria.Nombre;

                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string idParametro = Request.QueryString["id"];

            CategoriaEntidad categoria = new CategoriaEntidad()
            {
                Nombre = txtNombre.Text
            };

            try
            {
                if (string.IsNullOrWhiteSpace(idParametro) == false)
                {
                    /* Estoy Editando */
                    int id = Convert.ToInt32(idParametro);
                    categoria.Id = id;

                    categoriasNegocio.ActualizarCategoria(categoria);
                }
                else
                {
                    /* Estoy creando uno nuevo */
                    categoriasNegocio.InsertarCategoria(categoria);
                }
                Response.Redirect("~/Administracion/Categorias");
            }
            catch (ValidacionEntidadException ex)
            {
                lblError.Text = ex.Message;
                pnlError.Visible = true;
            }

        }
    }
}