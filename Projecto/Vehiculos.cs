using System;
//Servicios (mitad)
//Boletas (falta)
//Sucursal (casi terminado)
namespace Vehiculos{

    abstract class Vehiculo{

        private string? marca;
        private string? modelo;
        private string? patente;
        private int anio;
        private int kilometraje;

        public Vehiculo(string marca, string modelo, string patente, int anio, int kilometraje){
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
            this.anio= anio;
            this.kilometraje = kilometraje;
        }
        public string? Marca{
            get { return marca; }
            set { marca = value;}
        }
        public string? Modelo{
            get { return modelo; }
            set { modelo = value; }
        }
        public int Anio{
            get { return anio; }
            set { anio = value;}
        }
        public int Kilometraje{
            get { return kilometraje; }
            set { kilometraje = value; }
        }
        public string? Patente{
            get { return patente; }
            set { patente = value; }        
        }
        public abstract void describir();
    }
}