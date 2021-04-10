using EntidadesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ComentarioDatos
    {
        // Aca deberia tener una propiedad que sea de tipo BlogEntities
        // Y sacarlo de cada metodo

        public List<Comentario> TodosLosComentarios(int idPost)
        {
            BlogEntities entidades = new BlogEntities();

            var consulta = from com in entidades.Comentarios
                           where com.IdPost == idPost
                           select com;

            return consulta.ToList(); //recien aca se ejecuta la consulta armada antes
        }

        public List<Comentario> TodosLosComentarios()
        {
            BlogEntities entidades = new BlogEntities();
            return entidades.Comentarios.ToList();
        }

        public Comentario ObtenerComentario(int id)
        {
            BlogEntities entidades = new BlogEntities();
            return entidades.Comentarios.Where(c => c.Id == id).FirstOrDefault();
        }

        public void BorrarComentario(int id)
        {
            BlogEntities entidades = new BlogEntities();
            Comentario comentario = entidades.Comentarios.Where(c => c.Id == id).FirstOrDefault();
            if (comentario != null)
            {
                entidades.Comentarios.Remove(comentario);
            }
            entidades.SaveChanges();
        }

        public void CrearComentario(Comentario unComentario) // O recibir los valores por separado ej: (string autor, string comentario, int idPost)
        {
            BlogEntities entidades = new BlogEntities();
            //Me aseguro que el objeto es nuevo para que EF lo inserte
            Comentario comentarioACrear = new Comentario()
            {
                Autor = unComentario.Autor,
                Comentario1 = unComentario.Comentario1,
                IdPost = unComentario.IdPost
            };

            entidades.Comentarios.Add(comentarioACrear);
            entidades.SaveChanges();
        }

        public void ActualizarComentario(Comentario unComentario)
        {
            BlogEntities entidades = new BlogEntities();
            Comentario comentario = entidades.Comentarios.Where(c => c.Id == unComentario.Id).FirstOrDefault();

            comentario.Autor = unComentario.Autor;
            comentario.Comentario1 = unComentario.Comentario1;

            entidades.SaveChanges();
        }
    }
}
