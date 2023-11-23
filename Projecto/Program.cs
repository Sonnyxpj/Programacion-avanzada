using System;
using Pagos;
using Vehiculos;


    class Program{

        static void Main(string[] args){
            
            Automovil miAuto = new Automovil("x","xx","xx-xx-xx","Rojo", 2012, 100000);
            miAuto.describir();
            //Forma de crear el pago
            Console.WriteLine("Seleccione un método de pago:");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");

            int opcion = Convert.ToInt32(Console.ReadLine());
            IPago Mpago;
            switch (opcion){

                case 1:
                    Mpago = new Efectivo();
                    break;
                case 2:
                    Mpago = new Tarjeta();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    Mpago = new Efectivo();
                    break;
            }
            Console.WriteLine("Ingrese el monto a pagar:");
            double monto = Convert.ToDouble(Console.ReadLine());
            Mpago.Pago(monto);


            
            
            
            
            
        }
    }