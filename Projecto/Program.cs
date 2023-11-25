using System;
using Pagos;
using Vehiculos;
using Clientes;
using Boletas;


class Program{

    static void Main(string[] args){
        string? Nombre = "";
        string? Rut = "";
        int Vcorreo;
        string? Correo = "";
        int Vtelefono;
        int Telefono = 0;
        int Edad;
        Console.WriteLine("Bienvenido Dinobot's Mechanical Workshop.");
        Console.WriteLine("Ingrese su nombre completo por favor");        
        try{
            Nombre = Convert.ToString(Console.ReadLine());
            while(Nombre == null || Nombre == ""){
                Console.WriteLine("No se puede dejar en blanco el nombre");
                Console.WriteLine("Ingrese su nombre nuevamente:");
                Nombre = Convert.ToString(Console.ReadLine());
            }
        }finally{
            Console.WriteLine();
        }
        Console.Write("Ingrese su rut: ");
        try{
            Rut = Convert.ToString(Console.ReadLine());
            while(Rut == null || Rut == ""){
                Console.WriteLine("No se puede dejar en blanco el rut");
                Console.WriteLine("Ingrese su rut nuevamente");
                Rut = Convert.ToString(Console.ReadLine());
            }
        }finally{
            Console.WriteLine();
        }
        Console.WriteLine("¿Desea ingresar su correo?\n1) Sí\n2) No");
        Vcorreo = Convert.ToInt32(Console.ReadLine());
        switch(Vcorreo){
            case 1:
                Console.WriteLine("Ingrese su correo:");
                Correo = Convert.ToString(Console.ReadLine());
                while(Correo == null || Correo == ""){
                    Console.WriteLine("Por la opción que seleccionó, no se puede dejar en blanco");
                    Console.WriteLine("Vuelva a ingresar su correo");
                    Correo = Convert.ToString(Console.ReadLine());
                }
                break;
            case 2:
                Correo = "";
                break;
        }
        Console.WriteLine("¿Desea ingresar su número de telefóno?\n1) Sí\n2) No");
        Vtelefono = Convert.ToInt32(Console.ReadLine());
        switch(Vtelefono){
            case 1:
                Console.WriteLine("Ingrese su número de telfóno ejemplo (912345678)");
                Telefono = Convert.ToInt32(Console.ReadLine()); // 9 5715 9156
                while(Telefono < 900000000){
                    Console.WriteLine("Número de telefóno incorrecto");
                    Console.WriteLine("Ingrese nuevamente su número telefonico");
                    Telefono = Convert.ToInt32(Console.ReadLine());
                }
                break;
            case 2:
                Telefono = 0;
                break;
        }
        Console.WriteLine("Ingrese su edad");
        try{
            Edad = Convert.ToInt32(Console.ReadLine());
            while(Edad < 18){
                Console.WriteLine("No se puede ser menor de edad");
                Console.WriteLine("Ingrese nuevamente su edad por favor");
                Edad = Convert.ToInt32(Console.ReadLine());
                
            }
        }finally{
            Console.WriteLine("");
        }
        if(Vcorreo == 1 && Vtelefono == 1){
            Cliente cliente1 = new Cliente(Nombre, Rut, Correo, Telefono, Edad);
        }else if(Vcorreo == 1 && Vtelefono == 0){
            Cliente cliente1 = new Cliente(Nombre, Rut, Correo, Edad);
        }else if(Vcorreo == 0 && Vtelefono == 1){
            Cliente cliente1 = new Cliente(Nombre, Rut, Telefono, Edad);
        }else if(Vcorreo == 0 && Vtelefono == 0){
            Cliente cliente1 = new Cliente(Nombre, Rut, Edad);
        }
        Console.WriteLine("Selecciona el tipo de vehículo:");
        Console.WriteLine("1. Automóvil");
        Console.WriteLine("2. Motocicleta");
        Console.WriteLine("3. Camión");
        int opcionVehiculo = Convert.ToInt32(Console.ReadLine());
        switch(opcionVehiculo){
            case 1:
                Console.WriteLine("Ingrese la marca del automóvil: ");
                string? aMarca = Convert.ToString(Console.ReadLine());
                while (aMarca == null || aMarca == ""){
                    Console.WriteLine("Marca inválida.\nReingrese la marca del automóvil: ");
                    aMarca = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el modelo del automóvil: ");
                string? aModelo = Convert.ToString(Console.ReadLine());
                while (aModelo == null || aModelo == ""){
                    Console.WriteLine("Modelo inválido.\nReingrese el modelo del automóvil: ");
                    aModelo = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese la patente del automóvil: ");
                string? aPatente = Convert.ToString(Console.ReadLine());
                while (aPatente == null || aPatente == "" || aPatente.Length!=6){
                    Console.WriteLine("Patente inválida.\nReingrese la patente del automóvil: ");
                    aPatente = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el color del auto: ");
                string? aColor = Convert.ToString(Console.ReadLine());
                while (aColor == null){
                    Console.WriteLine("Color inválido.\nReingrese el color del automóvil: ");
                    aColor = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el año del auto: ");
                int aAnio = Convert.ToInt32(Console.ReadLine());
                while (aAnio <= 0){
                    Console.WriteLine("Año inválido.\nReingrese el año del automóvil: ");
                    aAnio = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el kilometraje del auto: ");
                int aKilometraje = Convert.ToInt32(Console.ReadLine());
                while (aKilometraje <= 0){
                    Console.WriteLine("Kilometraje inválido.\nReingrese el kilometraje del automóvil: ");
                    aKilometraje = Convert.ToInt32(Console.ReadLine());
                }
                Automovil auto1 = new Automovil(aMarca, aModelo, aPatente, aColor, aAnio, aKilometraje);
                break;
            case 2:
                Console.WriteLine("Ingrese la marca del camión: ");
                string? cMarca = Convert.ToString(Console.ReadLine());
                while (cMarca == null || cMarca == ""){
                    Console.WriteLine("Marca inválida.\nReingrese la marca del camión: ");
                    cMarca = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el modelo del camión: ");
                string? cModelo = Convert.ToString(Console.ReadLine());
                while (cModelo == null || cModelo == ""){
                    Console.WriteLine("Modelo inválido.\nReingrese el modelo del camión: ");
                    cModelo = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese la patente del camión: ");
                string? cPatente = Convert.ToString(Console.ReadLine());
                while (cPatente == null || cPatente == "" || cPatente.Length!=6){
                    Console.WriteLine("Patente inválida.\nReingrese la patente del camión: ");
                    cPatente = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el color del camión: ");
                int cCarga = Convert.ToInt32(Console.ReadLine());
                while (cCarga <= 0){
                    Console.WriteLine("Color inválido.\nReingrese el color del camión: ");
                    cCarga = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el año del camión: ");
                int cAnio = Convert.ToInt32(Console.ReadLine());
                while (cAnio <= 0){
                    Console.WriteLine("Año inválido.\nReingrese el año del camión: ");
                    cAnio = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el kilometraje del camión: ");
                int cKilometraje = Convert.ToInt32(Console.ReadLine());
                while (cKilometraje <= 0){
                    Console.WriteLine("Kilometraje inválido.\nReingrese el kilometraje del camión: ");
                    cKilometraje = Convert.ToInt32(Console.ReadLine());
                }
                Camion camion1 = new Camion(cMarca, cModelo, cPatente, cCarga, cAnio, cKilometraje);
                break;
            case 3:
                Console.WriteLine("Ingrese la marca de la moto: ");
                string? mMarca = Convert.ToString(Console.ReadLine());
                while (mMarca == null || mMarca == ""){
                    Console.WriteLine("Marca inválida.\nReingrese la marca de la moto: ");
                    mMarca = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el modelo de la moto: ");
                string? mModelo = Convert.ToString(Console.ReadLine());
                while (mModelo == null || mModelo == ""){
                    Console.WriteLine("Modelo inválido.\nReingrese el modelo de la moto: ");
                    mModelo = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese la patente de la moto: ");
                string? mPatente = Convert.ToString(Console.ReadLine());
                while (mPatente == null || mPatente == "" || mPatente.Length!=6){
                    Console.WriteLine("Patente inválida.\nReingrese la patente de la moto: ");
                    mPatente = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el color de la moto: ");
                int mCilindrada = Convert.ToInt32(Console.ReadLine());
                while (mCilindrada == 0){
                    Console.WriteLine("Color inválido.\nReingrese el color de la moto: ");
                    mCilindrada = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el año de la moto: ");
                int mAnio = Convert.ToInt32(Console.ReadLine());
                while (mAnio <= 0){
                    Console.WriteLine("Año inválido.\nReingrese el año de la moto: ");
                    mAnio = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el kilometraje de la moto: ");
                int mKilometraje = Convert.ToInt32(Console.ReadLine());
                while (mKilometraje <= 0){
                    Console.WriteLine("Kilometraje inválido.\nReingrese el kilometraje de la moto: ");
                    mKilometraje = Convert.ToInt32(Console.ReadLine());
                }
                Moto moto1 = new Moto(mMarca, mModelo, mPatente, mCilindrada, mAnio, mKilometraje);
                break;
            }

            //Mostrar menu
            Console.WriteLine("゜゜。。+゜゜。。MENU ゜゜。。+゜゜。。");
            Console.WriteLine("1. Ajuste de motor");
            Console.WriteLine("2. Balanceo de ruedas");
            Console.WriteLine("3. Cambio de aceite");
            Console.WriteLine("4. Cambio de bujías");
            Console.WriteLine("5. Cambio de correa de distribución");
            Console.WriteLine("6. Cambio de pastillas de freno");
            Console.WriteLine("7. Cambio de kit de embreague");
            Console.WriteLine("8. Cambio de suspensión y amortiguación");
            Console.WriteLine("9. Cambio de filtro de combustible");
            Console.WriteLine("10. Mantención de sistema electrónico");
            Console.WriteLine("11. Escáner");
            Console.WriteLine("12. Salir");
            Console.WriteLine("Ingresa la opción que necesitas:");
            
            int opcionArreglo = Convert.ToInt32(Console.ReadLine());
            switch(opcionArreglo){
                case 1:
                    Console.WriteLine("Se está ajustando el motor. \nTiempo estimado: 4 días. \nCosto: $700.000");
                    break;
                case 2:
                    Console.WriteLine("Se están balanceando las ruedas. \nTiempo estimado: 20 minutos. \nCosto: $10.000");
                    break;
                case 3:
                    Console.WriteLine("Se está cambiando el aceite del motor. \nTiempo estimado: 30 minutos. \nCosto: $8.000");
                    break;
                case 4:
                    Console.WriteLine("Se están cambiando las bujías. \nTiempo estimado: 20 minutos. \nCosto: $10.000");
                    break;
                case 5:
                    Console.WriteLine("Se está cambiando la correa de distribución. \nTiempo estimado: 3 horas. \nCosto: $60.000");
                    break;
                case 6:
                    Console.WriteLine("Se están cambiando las pastillas de freno. \nTiempo estimado: 30 minutos. \nCosto: $10.000");
                    break;
                case 7:
                    Console.WriteLine("Se está cambiando el Kit de embreague. \nTiempo estimado: 6 horas. \nCosto: $120.000");
                    break;
                case 8:
                    Console.WriteLine("Se está cambiando la suspensión y amortiguación. \nTiempo estimado: 2 horas. \nCosto: $45.000");
                    break;
                case 9:
                    Console.WriteLine("Se está cambiando el filtro de combustible. \nTiempo estimado: 15 minutos. \nCosto: $15.000");
                    break;
                case 10:
                    Console.WriteLine("Se está reparando el sistema electrónico. \nTiempo estimado: 20 minutos. \nCosto: $15.000");
                    break;
                case 11:
                    Console.WriteLine("Se está escaneando el sistema del vehículo. \nTiempo estimado: 30 minutos. \nCosto: $25.000");
                    break;
                case 12:
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            } 
            Console.WriteLine("Se está imprimiendo su boleta.");

            Boleta.barraCarga();

        }       
    }
