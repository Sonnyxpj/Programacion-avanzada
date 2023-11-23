using System;

class Program{

    static void Main(string[] args){
        Console.WriteLine("Ingrese su nombre por favor");
        string? nombre;
        try{
            nombre = Convert.ToString(Console.ReadLine());
        }catch (FormatException){

        }
    }
}