using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Random
        Random random = new Random();

        // Generar un número entero aleatorio
        int numeroEntero = random.Next();

        // Generar un número entero aleatorio en un rango específico (por ejemplo, entre 1 y 100)
        long numeroEnRango = random.Next(100000000, 999999999);

        // Generar un número decimal aleatorio
        double numeroDecimal = random.NextDouble();

        // Imprimir los resultados
        Console.WriteLine("Número entero aleatorio: " + numeroEntero);
        Console.WriteLine("Número en rango aleatorio (entre 1 y 100): " + numeroEnRango);
        //Console.WriteLine("Número decimal aleatorio: " + numeroDecimal);

        // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
        Console.ReadKey();
    }
}
