
class Automovil
{
    //atributos
    public string placa;
    public string color;
    public string marca;
    public string modelo;

    //Constructor
    public Automovil(string pl,string co,string ma,string mo)
    {
        this.placa = pl;
        this.color = co;
        this.marca = ma;
        this.modelo = mo;
    }

    public void Encender()
    {
        Console.WriteLine($"encendiendo el auto marca {this.marca}");
    }
}

class Program
{
    static void Main()
    {
        Automovil vw = new Automovil("CH-1234", "Amarillo", "Volkswagen", "Escarabajo");
        vw.Encender();

        Console.WriteLine("crea tu propio auto : ");
        Console.WriteLine("Marca : ");
        string marca = Console.ReadLine();

        Automovil autoPropio = new Automovil("ASDF", "Rojo", marca, "NINGUNO");
        autoPropio.Encender();
    }
}