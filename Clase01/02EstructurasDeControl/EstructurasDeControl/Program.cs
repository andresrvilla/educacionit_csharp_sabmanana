using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estructuras de Control");

            int numeroA = 10;
            int numeroB = 50;
            int numeroC = 200;

            // IF
            if (numeroA + numeroB < 200)
                // Cuando el if aplica a una unica instruccion no es obligatorio poner las llaves
                Console.WriteLine("La suma de numeroA y numeroB es menor a 200");
            else
            {
                Console.WriteLine("La suma de numeroA y numeroB es mayor o igual a 200");
            }
            
            if( numeroB + numeroC < 200)
            {
                Console.WriteLine("La suma de numeroB y numeroC es menor a 200");
            }
            else if(numeroC > 100)
            {
                Console.WriteLine("La suma de numeroB y numeroC es mayor o igual a 200 y numeroC es mayor a 100");
            }
            else
            {
                Console.WriteLine("No entro en ninguna condicion anterior");
            }



            // SWITCH

            switch (numeroA)
            {
                case 100:
                    Console.WriteLine("El valor es 100");
                    break;
                case 10:
                    Console.WriteLine("El valor es 10");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("El valor es 1 o 2");
                    break;
                default:
                    Console.WriteLine("No entro en ninguno de los casos posibles");
                    break;
            }

            // WHILE

            int contador = 0;
            int valorExterno = 10;
            while(contador < 10 && valorExterno==10)
            {
                Console.WriteLine("El valor de contador es {0}", contador);
                contador++;
            }

            // DO WHILE
            contador = 0;
            do
            {
                //Console.WriteLine("El valor de contador es " + contador);
                Console.WriteLine($"El valor de contador es {contador}");
                contador++;
            } while (contador < 10);

            // FOR
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"El valor de i es {i}.");
            }

            Console.ReadKey();
        }
    }
}
