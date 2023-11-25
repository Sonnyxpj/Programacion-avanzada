using System;

namespace Boletas{
    class Boleta{
        public static void imprimeBoleta(){
            string extraer = "Sucursal.txt";
            string salida = "Boleta.txt";
            string[] lineas = File.ReadAllLines(extraer);
            using (StreamWriter writer = new StreamWriter(salida, true)){
                foreach(string linea in lineas){
                    writer.Write(linea+"\n");
                }
            }
        }

        public static void barraCarga(){

            // Longitud total de la barra
            int largoTotal = 25;

            // Itera para mostrar el progreso
            for (int i = 0; i <= largoTotal; i++)
            {
                // Calcula el porcentaje completado
                double porcentajeProgreso = (double)i / largoTotal;

                // Calcula la cantidad de caracteres '#' para la barra
                int largoActual = (int)(porcentajeProgreso * largoTotal);

                // Crea la cadena de la barra
                string progresoBarra = "[" + new string('#', largoActual) + new string(' ', largoTotal - largoActual) + "]";

                // Muestra la barra en la consola
                Console.Write($"\r{progresoBarra} {porcentajeProgreso:P0}");

                // Simula un proceso en el que la barra avanza
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}