using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 10; i >= 0; i--, Console.WriteLine("Valor de salida: {0}", i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
