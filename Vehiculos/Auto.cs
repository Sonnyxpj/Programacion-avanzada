using System;

namespace Vehiculos{
    class Auto : Vehiculo{
        private int puertas;
        public Auto(string marca, string modelo, int anio, int puertas) : base(marca, modelo, anio){
            this.puertas = puertas;
        }
        public override void describir(){
            Console.WriteLine($"Auto: {Marca}, Modelo: {Modelo}, Año: {Anio}, {puertas} puertas");
        }
    }
}