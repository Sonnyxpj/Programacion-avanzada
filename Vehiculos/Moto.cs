using System;

namespace Vehiculos{

    class Moto : Vehiculo{
        public Moto(string marca, string modelo, int anio) : base(marca, modelo, anio){
        }
        public override void describir(){
            Console.WriteLine($"Moto: {Marca} {Modelo}, año: {Anio}");
        }
    }
}