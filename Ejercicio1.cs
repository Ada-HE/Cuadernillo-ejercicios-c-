using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double CP, PF, DESC;
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Programa para calcular el descuento por cierta cantidad a pagar");
            //Entrada
            Console.WriteLine("Ingrese la cantidad a pagar");
            CP= double.Parse(Console.ReadLine());
            //Proceso y salida
            if (CP >= 1800)
            {
                DESC = CP * 0.30;
            }
            else
            {
                DESC = CP * 0.10;
            }
            PF = CP - DESC;
            Console.WriteLine("El descuento es de:"+DESC);
            Console.WriteLine("La cantidad final a pagar es de:"+PF);
            Console.ReadKey();
        }
    }
}
