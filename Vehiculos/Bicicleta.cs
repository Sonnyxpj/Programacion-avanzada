using System;

namespace Vehiculos{
    class Bicicleta : Vehiculo{

        private int velocidades;

        public Bicicleta(string marca, string modelo, int anio, int velocidades) : base(marca, modelo, anio){
            this.velocidades = velocidades;
        }
        public override void describir(){
            Console.WriteLine($"Marca: {Marca} {Modelo}, Año: {Anio}, Velocicades: {velocidades}");
        }
    }
}