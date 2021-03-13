using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PostNegocio
    {
        private readonly PostDatos postDatos = new PostDatos();
        public List<Post> TodosLosPosts()
        {
            return postDatos.TodosLosPosts();
        }
    }
}
