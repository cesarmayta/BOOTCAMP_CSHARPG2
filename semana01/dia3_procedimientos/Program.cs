void CalcularAreaTriangulo(int baseTriangulo,int alturaTriangulo)
{
    double resultado = (baseTriangulo* alturaTriangulo) /2;
    Console.WriteLine($"El area del triangulo es {resultado}");
}

Console.WriteLine("Ingrese base del triangulo :");
int baseTriangulo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese altura del triangulo : ");
int alturaTriangulo = int.Parse(Console.ReadLine());

CalcularAreaTriangulo(baseTriangulo,alturaTriangulo);
