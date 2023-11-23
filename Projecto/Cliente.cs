using System;


namespace Clientes{

    class Clientes{
        private string? nombre;
        private string rut = "xx.xxx.xxx-x";
        private string correo = "ejemplo@gmail.com";
        private string telefono = "912345678";
        private int edad = 18;

        public Clientes(){

        }
        public Clientes(string nombre, string rut, string correo, string telefono, int edad){
            this.nombre = nombre;
            this.rut = rut;
            this.correo = correo;
            this.telefono = telefono;
            this.edad = edad;
        }
        public Clientes(string nombre, string rut, string telefono, int edad){
            this.nombre = nombre;
            this.rut = rut;
            this.telefono = telefono;
            this.edad = edad;
        }
        public string? Nombre{
            get {return nombre; }
            set {nombre = value; }    
        }
        public string Rut{
            get {return rut; }
            set {rut = value;}
        }
        public string Correo{
            get {return correo;}
            set {correo = value;}
        }
        public string Telefono{
            get {return telefono; }
            set {telefono = value; }
        }
        public int Edad{
            get {return edad; }
            set {edad = value; }
        }
            
        
    }
}