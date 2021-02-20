using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DiasDeLaSemana.Lunes);
            Console.WriteLine((int)DiasDeLaSemana.Lunes);
            DiasDeLaSemana diaMartes = DiasDeLaSemana.Martes;
            Console.WriteLine(diaMartes);

            // Dia martes suponiendo que lo cargo desde la base de datos
            DiasDeLaSemana unDia = (DiasDeLaSemana)1;
            Console.WriteLine(unDia);

            Console.ReadKey();
        }
    }
}
