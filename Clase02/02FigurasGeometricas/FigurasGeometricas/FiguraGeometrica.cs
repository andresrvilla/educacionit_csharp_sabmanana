using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    /*
     * internal (o sin visibilidad): Solo es visible en el mismo ensamblado
     * public: Visible para todos los ensamblados
     * private: Se usa dentro de otra clase
     */
    public abstract class FiguraGeometrica
    {
        public static string TiposFiguras = "Cuadrado,Rectangulo";

        public virtual double Area()
        {
            return 0;
        }

        public abstract double Perimetro();

        // VISIBILIDAD VALOR_RETORNO NOMBRE(PARAMETROS){}
        public void HacerNada()
        {

        }

        private class Punto // Solo es visible desde FiguraGeometrica
        {
            public double X { get; set; }

            public double Y { get; set; }
        }
    }
}
