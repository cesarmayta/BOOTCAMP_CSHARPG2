//arrays
int[] notas;

int cantidad = 0;
Console.WriteLine("INGRESE CANTIDAD DE NOTAS : ");
cantidad = int.Parse(Console.ReadLine());

notas = new int[cantidad];
//[0,1,2,3]
for(int i = 0;i < cantidad; i++)
{
    int numeroNota = i + 1;
    Console.WriteLine($"Ingrese nota {numeroNota} : ");
    notas[i] = int.Parse(Console.ReadLine()) ;
}

Console.WriteLine("Estas son tus Notas:");
double sumaTotal = 0;
foreach(var nota in notas)
{
    sumaTotal += nota;
    Console.WriteLine($"NOTA : {nota} ");
}

double promedio = sumaTotal / notas.Length;
Console.WriteLine($"El promedio es {promedio}");

//listas
List<string> asistentes = new List<string>();
string agregar = "si";
do
{
    Console.WriteLine("Ingrese el nombre del asistente : ");
    string nombre = Console.ReadLine();
    asistentes.Add(nombre);

    Console.WriteLine("¿Desea agregar otro asistente?");
    agregar = Console.ReadLine();

} while (agregar != "no");

Console.WriteLine("Lista de asistentes :");
foreach(var item in asistentes)
{
    Console.WriteLine(item);
}

//diccionario
Dictionary<int, string> dias = new Dictionary<int, string>
{
    {1,"Lunes" },
    {2,"Martes" },
    {3,"Miercoles" },
    {4,"Jueves" }
};

Console.WriteLine("Ingres el día de la semana : ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Es {dias[dia]}");

dias[5] = "Viernes";

foreach(var item in dias)
{
    Console.WriteLine($"{item.Key} - {item.Value}");    
}


