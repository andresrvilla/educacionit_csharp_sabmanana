using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PostDatos
    {
        public List<Post> TodosLosPosts()
        {
            return new List<Post>()
            {
                new Post(){ Titulo="CuerPo Uno", Resumen="Esta es la noticia Uno", Cuerpo="Esto es el contenido" },
                new Post(){ Titulo="CuerPo Dos", Resumen="Esta es la noticia Dos", Cuerpo="Esto es el contenido" },
                new Post(){ Titulo="CuerPo Tres", Resumen="Esta es la noticia Tres", Cuerpo="Esto es el contenido" },
                new Post(){ Titulo="CuerPo Cuatro", Resumen="Esta es la noticia Cuatro", Cuerpo="Esto es el contenido" }
            };
        }
    }
}
