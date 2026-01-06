using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ACTIVIDAD 1

            int numeroMes;

            Console.WriteLine("Ingrese un número entre el 1 y el 12");
            numeroMes = Convert.ToInt32(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida");
                    break;
            }


            // ACTIVIDAD 2

            int numeroEvaluar;

            Console.WriteLine("Ingrese un número");
            numeroEvaluar = Convert.ToInt32(Console.ReadLine());

            if((numeroEvaluar % 2) == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }


            //ACTIVIDAD 3

            const int precioHora = 5;
            const int precioBloque = 15;
            const int precioExtendido = 40;

            int tiempo;

            Console.WriteLine("Ingrese el tiempo que estuvo en el estacionamiento");
            tiempo = Convert.ToInt32(Console.ReadLine());

            switch(tiempo)
            {
                case 60:
                    Console.WriteLine("Usted debe pagar {0}", precioHora);
                    break;
                case 120:
                    Console.WriteLine("Usted debe pasar {0}", precioBloque);
                    break;
                default:
                    if(tiempo > 120)
                    {
                        Console.WriteLine("Usted debe pagar " + tiempo * precioExtendido);
                    } 
                    break;
            }
        }
    }
}
