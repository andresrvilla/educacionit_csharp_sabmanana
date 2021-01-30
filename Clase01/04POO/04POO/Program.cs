using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona();
            unaPersona.apellido = "Villa";
            unaPersona.nombre = "Andres";
            unaPersona.denominacion = "Instructor";

            Console.WriteLine(unaPersona.ObtenerNombreCompleto());

            Persona unAlumno = new Persona();
            unAlumno.apellido = "Gomez";
            unAlumno.nombre = "Ariel";
            unAlumno.denominacion = "Alumno";

            Console.WriteLine(unAlumno.ObtenerNombreCompleto());

            Persona otroAlumno = new Persona()
            {
                apellido = "Gonzalez",
                nombre = "Pedro",
                denominacion = "Alumno"
            };

            Console.WriteLine(otroAlumno.ObtenerNombreCompleto());

            Console.ReadKey();
        }
    }
}
