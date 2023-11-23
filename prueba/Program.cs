using System;

interface IMetodoPago
{
    void RealizarPago(decimal monto);
}

class PagoEnEfectivo : IMetodoPago
{
    public void RealizarPago(decimal monto)
    {
        Console.WriteLine($"Pago en efectivo por un monto de {monto:C}");
    }
}

class PagoConTarjeta : IMetodoPago
{
    public void RealizarPago(decimal monto)
    {
        Console.WriteLine($"Pago con tarjeta por un monto de {monto:C}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione un método de pago:");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Tarjeta");

        int opcion = Convert.ToInt32(Console.ReadLine());

        IMetodoPago metodoPago;

        switch (opcion)
        {
            case 1:
                metodoPago = new PagoEnEfectivo();
                break;

            case 2:
                metodoPago = new PagoConTarjeta();
                break;

            default:
                Console.WriteLine("Opción no válida. Seleccionando pago en efectivo por defecto.");
                metodoPago = new PagoEnEfectivo();
                break;
        }

        Console.WriteLine("Ingrese el monto a pagar:");
        decimal monto = Convert.ToDecimal(Console.ReadLine());

        metodoPago.RealizarPago(monto);

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}