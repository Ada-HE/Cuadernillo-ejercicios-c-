using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            char opcion;
            //Declarando e inicializando variables
            //se asigna el valor de 0 a las variables
            double dat1 = 0, dat2 = 0, resultado = 0;
            Console.WriteLine("Calculadora para sacar areas");
            Console.WriteLine("Selecciona una opcion:");
            Console.WriteLine("T-triangulo");
            Console.WriteLine("C-cuadrado");
            Console.WriteLine("R-rectangulo");
            Console.WriteLine("B-rombo");
            Console.WriteLine("Selecciona una opcion: ");
            opcion = char.Parse(Console.ReadLine());
            if (opcion == 'T' || opcion == 'R' || opcion == 'C' || opcion == 'B')
            {
                Console.WriteLine("Ingresa la altura o diagonal mayor:");
                dat1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la base o diagonal menor: ");
                dat2 = double.Parse(Console.ReadLine());
                //realiza la operacion segun la opcion
                switch (opcion)
                {
                    case 'T':
                        resultado = (dat1 * dat2)/2;
                        break;
                    case 'R':
                        resultado = dat1 * dat2;
                        break;
                    case 'C':
                        resultado = dat1 * dat2;
                        break;
                    case 'O':
                        resultado = (dat1 * dat2)/2;
                        break;
                }
                //salida
                Console.WriteLine("el resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("Verificar la opcion: ");
            }
            Console.ReadKey();
        }
    }
}
