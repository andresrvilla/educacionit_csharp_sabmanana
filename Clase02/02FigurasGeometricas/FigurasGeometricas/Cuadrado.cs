using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Cuadrado: Rectangulo
    {
        public override double Altura
        {
            get
            {
                return Base;
            }
            set
            {
                Base = value;
            }
        }

        public override string ToString()
        {
            return $"Cuadrado[Lado={Base}]";
        }
    }
}
