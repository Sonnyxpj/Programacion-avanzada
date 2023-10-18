
class Perro {
    //Atributos
    private string? nombre;
    private string? raza;
    private int edad;

    //Constructos
    public Perro() {
        Console.WriteLine("Se creo la instancia");
    }
    public void SetNombre(string nombre) {
        this.nombre = nombre;
    }
    public string GetNombre() {
        return this.nombre;
    }
    public void Ladrar() {
        Console.WriteLine("Guau Guau");
    }
    public void Comer() {
        Console.WriteLine("Ñan Ñan");
    }
}