using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvanzado
{
    class Persona
    {
        public string Apellido { get; set; } = "Apellido";

        public string Nombre { get; set; } = "Nombre";

        public Documento DNI { get; set; }

        public Documento DNIContacto { get; set; }

        //Propiedad calculada
        //public string NombreCompleto
        //{
        //    get
        //    {
        //        return $"{Apellido}, {Nombre}";
        //    }
        //}

        //Nueva forma de hacer las propiedades calculadas

        public string NombreCompleto => $"{Apellido}, {Nombre}, {DNI}";

        public string NombreCompletoConDescripcion => $"Apellido: {Apellido}, Nombre: {Nombre}, Dni: {DNI}, Dni Contacto: {DNIContacto?.Tipo ?? "Sin Contacto" } {DNIContacto?.Numero}";

        public Persona(string apellido, string nombre)
        {
            if (string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentException("Apellido no es válido");
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Nombre no es válido");
            }

            Apellido = apellido;
            Nombre = nombre;
        }

        public Persona(Documento dni, string apellido, string nombre) : this(apellido,nombre)
        {
            Documento porDefecto = new Documento() { Tipo = "Sin Identificar", Numero = null };

            //if (dni  == null)
            //{
            //    dni = porDefecto;
            //}

            //DNI = dni;

            //CONDICION ? VALOR_POSITIVA : VALOR_NEGATIVA;

            // Asigno con IF en linea
            //DNI = dni == null ? porDefecto : dni;

            // Condicional null

            DNI = dni ?? porDefecto;
        }

    }
}
