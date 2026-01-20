using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Seccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejecicio 1

            int exponente, potencia, potenciaConv;
            double resultado, resultadoParcial;

            Console.WriteLine("Ingrese el exponente");
            exponente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia");
            potencia = Convert.ToInt32(Console.ReadLine());

            if (potencia < 1)
            {
                resultadoParcial = exponente;
                potenciaConv = potencia * -1;

                for (int i = 1; i < potenciaConv; i++)
                {
                    resultadoParcial *= exponente;
                }

                resultado = 1 / resultadoParcial;
            } else
            {
                resultado = exponente;

                for (int i = 1; i < potencia; i++)
                {
                    resultado *= exponente;
                }
            }

            Console.WriteLine("El resultado de {0} elevado a la {1} es: {2}", exponente, potencia, resultado);

            // Ejercicio 2

            Console.WriteLine("Los números primos de cero a cien son: ");

            int j, num;
            bool primo;

            for (num = 1; num <= 100; num++)
            {
                primo = true;

                for (j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        primo = false;
                    }
                }

                if (primo == true)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
