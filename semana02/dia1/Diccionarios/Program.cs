//Diccionario
Dictionary<string, string> capitales = new Dictionary<string, string>
{
    {"Perú","Lima" },
    {"Ecuador", "Quito" },
    {"Chile","Santiago"},
    {"Colombia","Bogota"}
};
foreach (var item in capitales)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}

Console.WriteLine("Ingrese un país : ");
string pais = Console.ReadLine();
if (capitales.ContainsKey(pais))
{
    Console.WriteLine($"La capital de {pais} es {capitales[pais]}");
}
else
{
    Console.WriteLine($"No se encontró capital de {pais}");
    Console.WriteLine($"Ingrese la capital de {pais}");
    string nuevaCapital = Console.ReadLine();
    capitales[pais] = nuevaCapital;
    Console.WriteLine("Nueva capital Añadida");
    foreach(var item in capitales)
    {
        Console.WriteLine($"{item.Key} : {item.Value}");
    }
}

