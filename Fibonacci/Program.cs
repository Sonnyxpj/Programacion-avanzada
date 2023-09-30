using System;

namespace Fibonacci{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("Ingrese el número de términos de la serie: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Fibonacci(num);
        }

        static void Fibonacci( int num){

            int a = 0, b = 1;
            Console.Write("Serie de Fibonacci: ");
            for (int i = 1; i <= num; i++){
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            
            }
        }
    }
}