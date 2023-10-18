
class Test {

    public static void Main(string[] args) {

        Perro perro1 = new Perro();
        Perro perro2 = new Perro();
        perro1.SetNombre("Aroha");
        Console.WriteLine(perro1.GetNombre());

        perro2.SetNombre("Cachupin");
        Console.WriteLine(perro2.GetNombre());
    
    }
}