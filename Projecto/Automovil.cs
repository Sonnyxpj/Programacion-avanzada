using System;

namespace Vehiculos{

    class Automovil : Vehiculo{

        private string? color;

        public Automovil(string marca, string modelo, string patente, string color, int anio, int kilometraje) : base(marca, modelo, patente, anio, kilometraje){
            this.color = color;
        }
        public Automovil(string marca, string modelo, string patente, int anio, int kilometraje) : base(marca, modelo, patente, anio, kilometraje){
            
        }
        public string? Color{
            get { return color; }
            set { color = value; }
        }
        public override void describir(){
            Console.WriteLine($"Auto: {Marca}, Modelo: {Modelo}, Color: {Color}, Patente {Patente}, Del año {Anio}, Kilometraje {Kilometraje}");
        }
    }
}