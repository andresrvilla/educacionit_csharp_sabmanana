using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proyecto de repaso"); // Esto es un comentario

            /*
             * Asignacion de variables
             * AMBITO TIPO NOMBRE = DATO;
             * Declaracion de variable sin asignacion
             * AMBITO TIPO NOMBRE;
             */

            int numero = 0;
            int otroNumero;

            string texto = "Hola mundo";

            Console.WriteLine(texto);

            double numeroDecimal = 100.5;

            bool valorBooleano = true;

            int[] arrayDeEnteros;

            float numeroFloat = 10.5F;

            var unNumeroVar = 100.5;

            //unNumeroVar = "String";

            int[] unArray = new int[10]; // indice  0 -> 9

            unArray[0] = 10;
            // .
            // .
            // .
            unArray[9] = 10;
            //unArray[10] = 10;

            int[] arrayIniciado = new int[] { 10, 20, 30 };

            // 
            Console.ReadKey();
        }
    }
}
