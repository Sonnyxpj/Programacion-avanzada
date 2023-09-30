using System;

namespace area{

    class Program{

        static void Main(string[] args){

            Console.Write("Ingrese la longitud de la base: ");
            int Base = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la longitud del ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());

            double Area =CalcularArea(Base, ancho);

            Console.WriteLine($"El áre del rectandulo es: {Area}");
        }

        static double CalcularArea(int Base, int ancho){

            double area = Base * ancho;
            return area;
        }
    }
}