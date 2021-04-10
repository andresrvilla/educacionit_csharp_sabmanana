using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvanzado
{
    static class StringExtensions
    {
        public static int ContarPalabras(this string me)
        {
            string[] palabras = me.Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }

        public static string AgregarPrefijo(this string me, string prefijo)
        {
            return $"{prefijo} {me}";
        }

        public static int ToInt32(this string me)
        {
            int resultado = 0;
            try
            {
                resultado = Convert.ToInt32(me);
            }
            catch
            {
                resultado = 0;
            }
            return resultado;
        }
    }
}
