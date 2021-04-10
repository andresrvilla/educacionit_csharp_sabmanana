using Datos;
using EntidadesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComentarioNegocio
    {
        private ComentarioDatos comentarioDatos = new ComentarioDatos();

        public List<Comentario> TodosLosComentarios(int idPost)
        {
            return comentarioDatos.TodosLosComentarios(idPost);
        }

        public List<Comentario> TodosLosComentarios()
        {
            return comentarioDatos.TodosLosComentarios();
        }

        public Comentario ObtenerUnComentario(int id)
        {
            return comentarioDatos.ObtenerComentario(id);
        }

        public void BorrarComentario(int id)
        {
            comentarioDatos.BorrarComentario(id);
        }

        public void CrearComentario(Comentario unComentario)
        {
            comentarioDatos.CrearComentario(unComentario);
        }

        public void ActualizarComentario(Comentario unComentario)
        {
            comentarioDatos.ActualizarComentario(unComentario);
        }
    }
}
