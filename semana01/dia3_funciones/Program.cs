//FUNCIONES
int sumarDosNumeros(int numero1,int numero2)
{
    int resultado = numero1 + numero2;
    return resultado;
}

int suma = sumarDosNumeros(5, 3);
//Console.WriteLine($"LA SUMA ES {suma}");

//crear una funcion que calcule el area de un triangulo (base * altura /2)
double CalcularAreaTriangulo(int baseTriangulo,int alturaTriangulo)
{
    double resultado = (baseTriangulo * alturaTriangulo) / 2;
    return resultado;
}

//Console.WriteLine($"El area del triangulo es {CalcularAreaTriangulo(10, 12)}");

double CalcularAreaRectangulo(int baseRectangulo,int alturaRectangulo)
{
    return baseRectangulo * alturaRectangulo;
}
Console.WriteLine("Ingrese base : ");
int baseArea = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Altura : ");
int alturaArea = int.Parse(Console.ReadLine());
Console.WriteLine(" Escoga un area : ");
Console.WriteLine(@"
1 - Area del triangulo
2 - Area del rectangulo
");
string opcion =  Console.ReadLine();
switch (opcion)
{
    case "1":
        Console.WriteLine($"El area del Triangulo es {CalcularAreaTriangulo(baseArea, alturaArea)} ");
        break;
    case "2":
        Console.WriteLine($"El area del Rectangulo es {CalcularAreaRectangulo(baseArea,alturaArea)} ");
        break;
    default:
        Console.WriteLine("OPCION INCORRECTA ME VOY");
        return;
}