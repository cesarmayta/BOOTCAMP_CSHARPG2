//Diccionario
Dictionary<string, string> capitales = new Dictionary<string, string>
{
    {"Perú","Lima" },
    {"Ecuador", "Quito" },
    {"Chile","Santiago"},
    {"Colombia","Bogota"}
};

Console.WriteLine("Ingrese un país : ");
string pais = Console.ReadLine();
if (capitales.ContainsKey(pais))
{
    Console.WriteLine($"La capital de {pais} es {capitales[pais]}");
}
else
{
    Console.WriteLine($"No se encontró capital de {pais}");
}

