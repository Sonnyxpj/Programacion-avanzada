
class Natural {

    //Atributos
    private int valor;

    public int resultado;

    public Natural() {
        Console.WriteLine("Se asignado un núemro");
    }
    public Natural(int valor) {  
        Console.WriteLine($"Se le asigno el valor: {valor}"); 
        this.valor = valor;
    }
    public void SetValor(int valor) {
        this.valor = valor;
    }
    public int GetValor() { 
        return valor;
    }
    public void suma(int valor2) {
        resultado = (this.valor + valor2);
        Console.WriteLine($"El resultado de {this.valor} + {valor2} = {resultado}");
    }
    public void resta(int valor2) {
        resultado = (this.valor - valor2);
        Console.WriteLine($"El resultado de {this.valor} - {valor} = {resultado}");
    }

}