using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04POO
{
    class Persona: IDescriptible
    {
        // Miembros de la clase: atributos y metodos

        //Atributos
        //VISIBILIDAD PARA ATRIBUTOS Y METODOS
        /*
         * (nada) tipo nombre; -> protected -> visible dentro del objeto o en sus hijos
         * private tipo nombre; -> visible dentro del objeto
         * public tipo nombre; -> visible dentro y fuera del objeto
         */
        private string apellido;

        // Getters y Setters

        public string GetApellido()
        {
            return apellido;
        }

        public void SetApellido(string apellido)
        {
            //El this se refiere al objeto en el que se esta ejecutando el metodo
            this.apellido = apellido;
        }

        // Property Full Implementadas
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                // el parametro del valor que quiero setear 
                // viene con la palabra reservada "value"
                // value por ejemplo es 10 en esta sentencia:
                // o.Nombre = 10;
                nombre = value;
            }
        }

        //Property Auto implementada
        public string Denominacion { get; set; }

        public string ObtenerDescripcion()
        {
            return "Persona: " + ObtenerNombreCompleto();
        }

        //metodos

        public string ObtenerNombreCompleto()
        {
            return $"{Denominacion} {GetApellido()} {nombre}";
        }

        //Metodo sobrecargado
        public string ObtenerNombreCompleto(string denominacionAlternativa)
        {
            return $"{denominacionAlternativa} {GetApellido()} {nombre}";
        }
    }
}
