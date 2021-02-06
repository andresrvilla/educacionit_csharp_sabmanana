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
            Instructor unaPersona = new Instructor();
            unaPersona.SetApellido("Villa");
            unaPersona.Nombre = "Andres";
            unaPersona.Denominacion = "Instructor";
            unaPersona.NumeroCuenta = "lkasjdkla123";

            Console.WriteLine(unaPersona.ObtenerNombreCompleto());

            Alumno unAlumno = new Alumno();
            unAlumno.SetApellido("Gomez");
            unAlumno.Nombre = "Ariel";
            unAlumno.Denominacion = "Alumno";
            unAlumno.PagoAlDia = false;

            Console.WriteLine(unAlumno.ObtenerNombreCompleto());

            Alumno otroAlumno = new Alumno()
            {
                Nombre = "Pedro",
                Denominacion = "Alumno",
                PagoAlDia = true
            };
            otroAlumno.SetApellido("Gonzalez");

            Console.WriteLine(otroAlumno.ObtenerNombreCompleto());
            Console.WriteLine(otroAlumno.ObtenerNombreCompleto("Señor"));

            IDescriptible descriptible = new Persona();
            descriptible = unAlumno;

            Persona[] participantes = new Persona[10];

            Persona unaPersonaCualquiera = new Instructor();
            unaPersonaCualquiera.ObtenerNombreCompleto();

            participantes[0] = new Instructor();
            participantes[1] = new Administrativo();
            participantes[2] = new Alumno();
            participantes[3] = new Alumno();
            participantes[4] = new Alumno();
            participantes[5] = new Alumno();





            Console.ReadKey();
        }
    }
}
