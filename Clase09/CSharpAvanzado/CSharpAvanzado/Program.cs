using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvanzado
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://blog.elmah.io/log4net-tutorial-the-complete-guide-for-beginners-and-pros/

            XmlConfigurator.Configure(new FileInfo("app.config"));

            ILog log = LogManager.GetLogger(typeof(Program));

            log.Debug("Hola soy un debug");
            log.Info("Hola soy un mensaje info");
            log.Warn("Hola soy advertencia");
            log.Error("Soy un mensaje de error");
            log.Fatal("Soy un mensaje fatallllll");

            string elapellido = "Villa";

            Documento elDocumento = new Documento()
            {
                Tipo = "DNI",
                Numero = 1231231
            };

            Persona persona = new Persona(null, nombre: "Andrés", apellido: elapellido);
            Console.WriteLine(persona.NombreCompletoConDescripcion);

            //Objetos anonimos


            Console.Write("Ingrese el ID:");
            string id = Console.ReadLine();
            Console.Write("Ingrese el Nombre:");
            string nombreCurso = Console.ReadLine();

            var o = new { IdCurso = id, NombreCurso = nombreCurso };

            Console.WriteLine(o.IdCurso);
            Console.WriteLine(o.NombreCurso);

            string frase = "Hola, como estas? Todo bien?";
            //int cantidadPalabras = FuncionesString.ContarPalabras(frase);
            int cantidadPalabras = frase.ContarPalabras();

            Console.WriteLine(frase.AgregarPrefijo("La frase es"));
            Console.WriteLine($"Cantidad Palabras: {cantidadPalabras}");

            GenericList<string> listaDeString = new GenericList<string>();
            listaDeString.Add("Dato Uno");
            listaDeString.Add("Dato Dos");
            listaDeString.Add("Dato Tres");
            listaDeString.Add("Dato Cuatro");
            listaDeString.Add("Dato Cinco");

            foreach (var item in listaDeString)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
