//int a = 0;
//string nombre = "cesar";
//double total = 0;
//array
int[] notas;
int cantidad = 0;
Console.WriteLine("INGRESE CANTIDAD DE NOTAS : ");
cantidad = Convert.ToInt32(Console.ReadLine());

notas = new int[cantidad];
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine($"INGRESE NOTA {i + 1} : ");
    notas[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("se ingresaron todas las notas...");