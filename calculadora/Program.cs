
using System;

namespace Calculadora{

    class Program{

        static void Main(string[] args){
            Console.Write("Ingrese el primer número: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seleccione una operación: ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            int opc = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch(opc){
                case 1:
                    resultado = num + num2;
                    break;
                case 2:
                    resultado = num - num2;
                    break;
                case 3:
                    resultado = num * num2;
                    break;
                case 4:
                    resultado = num / num2;
                    break;
                default:
                    Console.WriteLine("Opción invalida");
                    return;
            }

            Console.Write($"El resultado es: {resultado}");

            
        }
    }
}