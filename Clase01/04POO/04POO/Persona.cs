using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04POO
{
    class Persona
    {
        //Atributos
        //VISIBILIDAD PARA ATRIBUTOS Y METODOS
        /*
         * (nada) tipo nombre; -> protected -> visible dentro del objeto o en sus hijos
         * private tipo nombre; -> visible dentro del objeto
         * public tipo nombre; -> visible dentro y fuera del objeto
         */
        public string apellido;

        public string nombre;

        public string denominacion;

        //metodos

        public string ObtenerNombreCompleto()
        {
            return $"{denominacion} {apellido} {nombre}";
        }
    }
}
