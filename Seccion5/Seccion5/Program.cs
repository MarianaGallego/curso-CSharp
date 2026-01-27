using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.WriteLine("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while ((opcion < 1) || (opcion > 4));

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;

                case 2:
                    
                    break;

                case 3:

                    break;

                case 4:

                    break;
            }
        }

        static void Sumar()
        {
            decimal num1, num2, resultado;

            Console.WriteLine("Ingresa el primer número");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }

        static decimal Restar()
        {
            decimal num1, num2, resultado;

            Console.WriteLine("Ingresa el primer número");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);

            return resultado;
        }
    }
}
