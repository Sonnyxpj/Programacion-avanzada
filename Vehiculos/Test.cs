using System;
using Vehiculos;


class Test{

        static void Main(string[] args){
            
            Auto miAuto = new Auto("Toyota", "Rav 4", 2022, 5);
            Moto miMoto = new Moto("Honda", "CBR", 2021);
            Bicicleta miBicicleta = new Bicicleta("BMX", "Negra", 2020, 5);

            miAuto.describir();
            miMoto.describir();
            miBicicleta.describir();
        }
    }
