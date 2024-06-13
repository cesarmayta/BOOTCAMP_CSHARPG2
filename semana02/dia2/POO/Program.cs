
class Automovil
{
    //atributos
    private string placa;
    private string color;
    public string marca;
    public string modelo;

    public string Placa { get => placa; set => placa = value; }


    //Constructor
    public Automovil(string pl,string co,string ma,string mo)
    {
        this.placa = pl;
        this.color = co;
        this.marca = ma;
        this.modelo = mo;
    }

    public void Mostrar()
    {
        Console.WriteLine($"MARCA : {this.marca}");
        Console.WriteLine($"PLACA : {this.placa}");
        Console.WriteLine($"COLOR : {this.color}");
        Console.WriteLine($"MODELO : {this.modelo}");

    }

    public void SetColor(string color)
    {
        this.color=color;
    }

    public string GetColor()
    {
        return this.color;
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
        //Console.WriteLine($"placa {vw.placa}");
        vw.marca = "Daewo";
        vw.Placa = "RH 23423";
        vw.SetColor("Rojo");
        Console.WriteLine($"PLACA : {vw.Placa}");
        Console.WriteLine($"El nuevo color del auto es {vw.GetColor()}");
        //vw.Encender();

        //Console.WriteLine("crea tu propio auto : ");
        //Console.WriteLine("Marca : ");
        //string marca = Console.ReadLine();

        //Automovil autoPropio = new Automovil("ASDF", "Rojo", marca, "NINGUNO");
        //autoPropio.Encender();
    }
}