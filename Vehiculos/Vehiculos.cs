using System;

namespace Vehiculos{
    abstract class Vehiculo{
        private string? marca;
        private string? modelo;
        private int anio;

        public Vehiculo(string marca, string modelo, int anio){
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }
        public string? Marca{
            get { return marca; }
        }
        public string? Modelo{
            get { return modelo; }
        }
        public int Anio{
            get { return anio; }
        }
        public abstract void describir();
    }
}