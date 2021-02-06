using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Rectangulo: FiguraGeometrica
    {
        private const double BASEINICIAL = 10;

        private const double ALTURAINICIAL = 20;

        public Rectangulo()
        {
            Base = BASEINICIAL;
            Altura = ALTURAINICIAL;
        }

        public Rectangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        ~Rectangulo()
        {
            // Finalizador o destructor
            // Se ejecuta cuando pasa el Garbage Collector
        }

        public virtual double Base { get; set; }

        public virtual double Altura { get; set; }

        public sealed override double Area()
        {
            return Base * Altura;
        }

        public sealed override double Perimetro()
        {
            return Base * 2 + Altura * 2;
        }

        public override string ToString()
        {
            return $"Rectangulo[Base={Base};Altura={Altura}]";
        }
    }
}
