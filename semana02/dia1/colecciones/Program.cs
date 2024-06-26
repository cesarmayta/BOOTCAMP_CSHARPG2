﻿//int a = 0;
//string nombre = "cesar";
//double total = 0;
//array
int[] notas;
int cantidad = 0;

//FUNCIONES
double CalcularPromedioNotas(int[] notas)
{
    int cantidad = notas.Length;
    double sumaNotas = 0;
    double promedio = 0;

    for(int i = 0; i < cantidad; i++)
    {
        sumaNotas = sumaNotas + notas[i]; //acumulador
    }
    promedio = sumaNotas / cantidad;
    return promedio;
}

//uso de foreach
double CalcularPromedioForEach(int[] notas)
{
    double sumaNotas = 0;
    foreach(var nota in notas)
    {
        sumaNotas += nota;
    }
    return sumaNotas / notas.Length;
}

void CalularMayor(int[] notas)
{
    int mayor = 0;
    foreach (var nota in notas)
    {
        if (nota > mayor)
        {
            mayor = nota;
        }
    }
    Console.WriteLine($"EL Número Mayor es :{mayor}");
}

//crear procedimiento que muestre el mayor y menor de los valores del array


Console.WriteLine("INGRESE CANTIDAD DE NOTAS : ");
cantidad = Convert.ToInt32(Console.ReadLine());
notas = new int[cantidad];
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine($"INGRESE NOTA {i + 1} : ");
    notas[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("se ingresaron todas las notas...");
double promedio = CalcularPromedioForEach(notas);
Console.WriteLine($"EL PROMEDIO DE LAS NOTAS ES : {promedio}");
CalularMayor(notas);