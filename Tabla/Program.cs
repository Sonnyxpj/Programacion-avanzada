using System;

namespace Tabla{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++){
                double resultado = num * i;
                Console.WriteLine($"{num} x {i} = {resultado}");
            }

        }
    }
}