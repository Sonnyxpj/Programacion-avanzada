using System;

namespace Vehiculos{

    class Camioneta : Vehiculo{

        private int capCarga;

        public Camioneta(string marca, string modelo, string patente, int anio, int kilometraje, int CapCarga ) : base(marca, modelo, patente, anio, kilometraje){
            this.CapCarga = CapCarga;
        }
        public int CapCarga{
            get { return capCarga; }
            set {capCarga = value;}
        }

        public override void describir(){
            Console.WriteLine($"Camioneta Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Capacidad de carga: {capCarga}KG, Patente: {Patente}, Kilometraje: {Kilometraje} ");
        }
    }
}