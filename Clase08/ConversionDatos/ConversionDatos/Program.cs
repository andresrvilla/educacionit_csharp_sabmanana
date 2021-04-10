using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroEnString = "32";
            int numero = Convert.ToInt32(numeroEnString); //numero va a ser 32

            long numeroGrande = numero;

            int otroInt = (int)numeroGrande;

            double numeroDecimal = 1234.5;

            int a = (int)numeroDecimal; //"Casteo" a int, tomando solo la parte entera

            // Si hay error de casteo lanza "InvalidCastException"

            //Conversion Boxing

            int enteroFueraCaja = 1000;

            //"boxing"
            object o = enteroFueraCaja;

            //unboxing

            int sacoDeCaja = (int)o;


            //Tira un invalidCastException
            //string noFunciona = (string)o;

            string funciona = o as string;
            

            Console.ReadKey();
        }
    }
}
