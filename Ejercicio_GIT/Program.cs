using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                double resultado, num1 = 5, num2 = 10;
                Console.WriteLine("1. Suma\n" +
                    "2. Resta\n" +
                    "3. Multiplicacion\n" +
                    "4. Salir\n" +
                    "Selecciona una opción:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        resultado = Suma(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    case 2:
                        resultado = Resta(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    case 3:
                        resultado = Multiplicacion(num1, num2);
                        Console.WriteLine(resultado);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa");
                        break;
                }
            } while (opcion != 4);

        }

        static double Suma(double num1,double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }
        static double Resta(double num1,double num2)
        {
            double resultado = num1 - num2;
            return resultado;
        }
        static double Multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
    }
}
