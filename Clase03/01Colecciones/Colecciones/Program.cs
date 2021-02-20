using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cursos = new string[3];
            cursos[0] = "Introduccion a c#";
            cursos[1] = "HTML";
            cursos[2] = "Web.NET con C#.NET";
            //cursos[3] = "Javascript"; Genera error por que el indice no existe

            List<string> misCursos = new List<string>();
            Console.WriteLine($"Capacidad: {misCursos.Capacity}");
            misCursos.Add("Introducción a c#");
            misCursos.Add("HTML");
            misCursos.Add("Web.NET con C#.NET");
            misCursos.Add("Javascript");
            misCursos.Add("Angular");
            Console.WriteLine($"Capacidad: {misCursos.Capacity}");

            List<int> misNumeros = new List<int>()
            {
                13,
                17,
                32,
                14,
                257
            };

            //For - Next
            for (int i = 0; i < misCursos.Count; i++)
            {
                Console.WriteLine(misCursos[i]);
            }

            Console.WriteLine("***************************");
            misCursos.Remove("HTML");
            misCursos.RemoveAt(1);


            misCursos.Sort();

            //Foreach
            foreach (string curso in misCursos)
            {
                Console.WriteLine(curso);
            }

            Console.WriteLine("***************************");

            //Inicializo la lista con el inicializaror de objetos crearndo los objetos en el momento
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre="Juan", Apellido="Cardozo"},
                new Persona() { Nombre="Brenda", Apellido="Herrera"}
            };

            //Creo el objeto previamente asignandolo a una variable y luego lo agrego con esa referencia
            Persona unAlumno = new Persona()
            {
                Apellido = "Cardozo",
                Nombre = "Juan"
            };

            personas.Add(unAlumno);

            //Agrego el objeto inicializandolo al momento de agregarlo
            personas.Add(new Persona() { Nombre = "Rodrigo", Apellido = "Molinari" });


            foreach (var item in personas)
            {
                Console.WriteLine($"Apellido: {item.Apellido} Nombre: {item.Nombre}");
            }

            Console.ReadKey();
        }
    }
}
