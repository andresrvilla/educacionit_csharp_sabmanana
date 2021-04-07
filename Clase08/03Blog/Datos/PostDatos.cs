using Entidades;
using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PostDatos
    {
        private readonly string cadenaDeConexion;

        public PostDatos()
        {
            cadenaDeConexion = ConfigurationManager.ConnectionStrings["BlogDatabase"].ConnectionString;
        }

        public List<PostEntidad> TodosLosPosts()
        {

            List<PostEntidad> resultado = new List<PostEntidad>();
            try
            {

                //Voy a ir cargando la lista de "Post" leyendo desde la base de datos

                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {

                    SqlCommand comando = new SqlCommand("SELECT Id,Titulo,Resumen,Cuerpo FROM Post", conexion);
                    conexion.Open();

                    // Ejecutar el comando y leer los datos
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PostEntidad post = new PostEntidad()
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

            }
            catch (SqlException ex)
            {
                
                throw new CapaDeDatosException();
            }
            finally
            {
                //por ejemplo puedo cerrar la conexion con la base de datos
                //conexion.close();
            }

            return resultado;
        }

        public PostEntidad ObtenerPost(int idPost)
        {
            PostEntidad elPost = null;

            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"SELECT Id,Titulo,Resumen,Cuerpo FROM Post WHERE Id={idPost}",conexion);
                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        elPost = new PostEntidad()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Titulo = reader.GetString(1),
                            Resumen = reader.GetString(2),
                            Cuerpo = reader.GetString(3)
                        };
                    }
                }

            }

            return elPost;
        }

        public void ActualizarPost(PostEntidad post)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = $"UPDATE [Post] SET [Titulo] = '{post.Titulo}' ,[Resumen] = '{post.Resumen}',[Cuerpo] = '{post.Cuerpo}' WHERE Id={post.Id}";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void InsertarPost(PostEntidad post)
        {
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = $"INSERT INTO Post (Titulo,Resumen,Cuerpo) VALUES ('{post.Titulo}','{post.Resumen}','{post.Cuerpo}')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void BorrarPost(int idPost)
        {
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = $"DELETE FROM Post WHERE Id={idPost}";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
