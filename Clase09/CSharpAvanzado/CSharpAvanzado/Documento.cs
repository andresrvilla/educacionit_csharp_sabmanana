using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvanzado
{
    class Documento
    {
        public string Tipo { get; set; }

        //Este int puede admitir el valor null
        //public Nullable<int> Numero { get; set; }
        public int? Numero { get; set; }

        public override string ToString()
        {
            return $"{Tipo} {Numero}";
        }
    }
}
