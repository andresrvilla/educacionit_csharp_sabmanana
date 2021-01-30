using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = suma(10, 20);
            Console.WriteLine(resultado);
            saludo("Andres");

            Console.ReadKey();
        }

        static int suma(int a, int b)
        {
            return a + b;
        }

        static void saludo(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
    }
}
