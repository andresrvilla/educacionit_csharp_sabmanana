using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvanzado
{
    static class FuncionesString
    {
        public static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}
