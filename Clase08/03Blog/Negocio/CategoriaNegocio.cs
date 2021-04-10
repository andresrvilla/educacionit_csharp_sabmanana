using Datos;
using Entidades;
using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private CategoriaDatos categoriaDatos = new CategoriaDatos();

        public List<CategoriaEntidad> ObtenerTodasLasCategorias()
        {
            //return categoriaDatos.TodasLasCategorias();
            //Llamo al stored procedure para probarlo
            return categoriaDatos.TodasLasCategoriasStoredProcedure();
        }

        public CategoriaEntidad ObtenerCategoria(int id)
        {
            return categoriaDatos.ObtenerCategoria(id);
        }

        public void InsertarCategoria(CategoriaEntidad categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ValidacionEntidadException("El nombre de la categoría es requerido");
            }

            categoriaDatos.InsertarCategoria(categoria);
        }

        public void ActualizarCategoria(CategoriaEntidad categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ValidacionEntidadException("El nombre de la categoría es requerido");
            }

            categoriaDatos.ActualizarCategoria(categoria);
        }

        public void BorrarCategoria(CategoriaEntidad categoria)
        {
            categoriaDatos.BorrarCategoria(categoria);
        }
    }
}
