using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PostDatos
    {
        public List<Post> TodosLosPosts()
        {
            List<Post> resultado = new List<Post>();

            //Voy a ir cargando la lista de "Post" leyendo desde la base de datos

            using (SqlConnection conexion = new SqlConnection("Server=.;Database=EducacionIT.Blog.Sab;Trusted_Connection=True;"))
            {

                SqlCommand comando = new SqlCommand("SELECT Id,Titulo,Resumen,Cuerpo FROM Post", conexion);
                conexion.Open();

                // Ejecutar el comando y leer los datos
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Post post = new Post()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Titulo = reader.GetString(1),
                            Resumen = reader.GetString(2),
                            Cuerpo = reader.GetString(3)
                        };
                        resultado.Add(post);
                    }
                }

                //conexion.Close(); Con el using no es necesario poner el close
            } //Cuando se sale del bloque ejecuta el "Dispose()" del objeto

            return resultado;
        }
    }
}
