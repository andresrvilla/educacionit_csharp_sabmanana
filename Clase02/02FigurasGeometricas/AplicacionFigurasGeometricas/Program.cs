using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasGeometricas;

namespace AplicacionFigurasGeometricas
{
    class Program
    {
        public const string version = "1.0.0";
        static void Main(string[] args)
        {
            FiguraGeometrica.TiposFiguras = "Cuadrado,Rectangulo,Circunferencia";
            // version = "x"; Error porque es constante
            Console.WriteLine("Figuras Geometricas v"+version);
            Console.WriteLine("Tipos " + FiguraGeometrica.TiposFiguras);
            Console.WriteLine("*******************");

            //No puedo crear el objeto figura geometrica porque es abstracto
            FiguraGeometrica figura; // = new FiguraGeometrica();

            Rectangulo miPrimerFigura = new Rectangulo()
            {
                Base = 10,
                Altura= 30
            };
            Console.WriteLine(miPrimerFigura);
            Console.WriteLine("El perimetro de la figura es " + miPrimerFigura.Perimetro());
            Console.WriteLine("El area de la figura es " + miPrimerFigura.Area());

            Circunferencia circunferencia = new Circunferencia()
            {
                Radio = 15
            };

            Console.WriteLine(circunferencia);
            Console.WriteLine("El perimetro de la figura es " + circunferencia.Perimetro());
            Console.WriteLine("El area de la figura es " + circunferencia.Area());

            Cuadrado cuadrado = new Cuadrado()
            {
                Base = 20,
                Altura = 10
            };

            Console.WriteLine(cuadrado);
            Console.WriteLine("El perimetro de la figura es " + cuadrado.Perimetro());
            Console.WriteLine("El area de la figura es " + cuadrado.Area());


            Rectangulo rectanguloConstructor = new Rectangulo(10,15);
            Console.WriteLine(rectanguloConstructor);
            Console.WriteLine("El perimetro de la figura es " + rectanguloConstructor.Perimetro());
            Console.WriteLine("El area de la figura es " + rectanguloConstructor.Area());

            Console.ReadKey();
        }
    }
}
