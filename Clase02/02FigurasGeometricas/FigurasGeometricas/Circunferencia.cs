using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Circunferencia : FiguraGeometrica
    {
        public double Radio { get; set; }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
