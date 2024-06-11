////LISTAS
//List<string> dias = new List<string> { "lunes", "martes", "miercoles" };
//Console.WriteLine(string.Join(", ", dias));
////agregar valores
//dias.Add("jueves");
//Console.WriteLine(string.Join(", ", dias));
////eliminar valores
//dias.RemoveAt(3);
//Console.WriteLine(string.Join(", ", dias));
//dias[0] = "Domingo";
//Console.WriteLine(string.Join(", ", dias));

//foreach (string dia in dias)
//{
//    Console.WriteLine(dia);
//}
List<double> notas = new List<double>();

Console.WriteLine("Ingrese notas de estudiantes . Escriba 'fin' para terminar el ingreso");
while (true)
{
    Console.WriteLine("Ingrese Nota : ");
    string? nota = Console.ReadLine();

    if(nota.ToLower() == "fin")
    {
        break;
    }

    notas.Add(double.Parse(nota));
}
Console.WriteLine("======== NOTAS =======");
Console.WriteLine(string.Join(", ", notas));
Console.WriteLine($"La nota mayor es : {notas.Max()}");
Console.WriteLine($"La nota menor es : {notas.Min()}");
Console.WriteLine($"El promedio es : {notas.Average()}");

