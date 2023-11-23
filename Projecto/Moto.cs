using System;

namespace Vehiculos{
    class Moto : Vehiculo{
        private int cilindrada;

        public Moto(string marca, string modelo, string patente, int anio, int kilometraje, int cilindrada) : base(marca, modelo, patente, anio, kilometraje){
            this.cilindrada = cilindrada;
        }
        public int Cilindrada{
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        public override void describir(){
            Console.WriteLine($"Moto: {Marca}, Modelo: {Modelo}, Año: {Anio}, Cilindrada: {Cilindrada} cc, Patente: {Patente}, Kilometraje {Kilometraje}");
        }
    }
}