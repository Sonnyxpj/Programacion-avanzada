using System;


namespace Clientes{

    class Cliente{
        private string? nombre = "x";
        private string rut = "11.111.111-1";
        private string correo = "nadie@nada.non";
        private int telefono = 912345678;
        private int edad = 18;

        public Cliente(){

        }
        public Cliente(string nombre, string rut, string correo, int telefono, int edad){
            this.nombre = nombre;
            this.rut = rut;
            this.correo = correo;
            this.telefono = telefono;
            this.edad = edad;
        }

        public Cliente(string nombre, string rut, int telefono, int edad){
            this.nombre = nombre;
            this.rut = rut;
            this.telefono = telefono;
            this.edad = edad;
        }
        public Cliente(String nombre, string rut, string correo, int edad){
            this.nombre = nombre;
            this.rut = rut;
            this.correo = correo;
            this.edad = edad;
        }
        public Cliente(string nombre, string rut, int edad){
            this.nombre = nombre;
            this.rut = rut;
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
        public int Telefono{
            get {return telefono; }
            set {telefono = value; }
        }
        public int Edad{
            get {return edad; }
            set {edad = value; }
        }
            
        
    }
}