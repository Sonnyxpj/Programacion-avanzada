using System;

namespace potencia1{

    class Program{

        static void Main(string[] args){

            Console.Write("Ingrese la base: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exp = Convert.ToInt32(Console.ReadLine());

            potencia(Base, exp);
        }

        static void potencia(int Base, int exp){

            double resultado = Math.Pow(Base, exp);
            Console.WriteLine($"El resultado de {Base} ^ {exp} es: {resultado}");
        }
    }
}