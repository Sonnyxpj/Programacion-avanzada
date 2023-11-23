using System;

class Program
{
    static void Main()
    {
        try
        {
            // Código que podría generar una excepción
            int resultado = Dividir(10, 1);
            Console.WriteLine("El resultado es: " + resultado);
        }
        catch (DivideByZeroException ex)
        {
            // Captura y maneja la excepción específica de división por cero
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Captura y maneja otras excepciones no especificadas
            Console.WriteLine("Ocurrió un error: " + ex.Message);
        }
        finally
        {
            // Código que se ejecutará siempre, ocurra o no una excepción
            Console.WriteLine("Finalizando la aplicación.");
        }
    }

    static int Dividir(int numerador, int denominador)
    {
        // Intenta realizar la división
        return numerador / denominador;
    }
}
