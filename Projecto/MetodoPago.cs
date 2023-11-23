using System;

namespace Pagos{
    
    class Efectivo : IPago{
       
        public void Pago(double Total){
            Console.WriteLine($"Tipo de pago: Efectivo \nMonto a pagar: {Total}");
        }
    }
    class Tarjeta : IPago{

        public void Pago(double Total){
            Console.WriteLine($"Tipo de pago: Debito \nMonto a pagar: {Total}");
        }
    }

}