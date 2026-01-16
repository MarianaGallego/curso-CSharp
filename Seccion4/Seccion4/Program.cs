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
            byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Console.WriteLine("Ingresa el número de alumnos");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.WriteLine("Ingresa la calificación: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificacion;
            }

            // Calcular promedio
            promedio = sumaCalif / numAlumnos;

            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
