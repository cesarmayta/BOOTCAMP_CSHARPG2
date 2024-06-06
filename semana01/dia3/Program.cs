﻿// VARIABLES
double valorCompra = 3.741;
double valorVenta = 3.747;
double montoOrigen = 0;
double montoDestino = 0;
int opcion = 0;

// PROCESO
while(opcion != 3)
{
    // ENTRADAS
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine(" CONVERTIR DE MONEDAS VERSION 1.0");
    Console.WriteLine("===================================");
    Console.WriteLine(@"
    OPCIÓN 1 : Convertir de soles a dolares
    OPCIÓN 2 : Convertir de dolares a soles
    OPCIÓN 3 : Salir
    ");
    Console.WriteLine("Ingrese una opción del menú : ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("ELEGISTE CONVERTIR DE SOLES A DOLARES");
            Console.WriteLine("Ingrese Monto en Soles :");
            montoOrigen = double.Parse(Console.ReadLine());
            montoDestino = montoOrigen / valorVenta;
            Console.WriteLine($"{montoOrigen} soles es igual a {Math.Round(montoDestino,2)} dolares");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("ELEGISTE CONVERTIR DE DOLARES A SOLES");
            Console.WriteLine("Ingrese el Monto en Dolares : ");
            montoOrigen = double.Parse(Console.ReadLine());
            montoDestino = montoOrigen * valorCompra;
            Console.WriteLine($"{montoOrigen} dolares es igual a {Math.Round(montoDestino,2)} soles");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("ADIOS ....");
            return;
        default:
            Console.Clear();
            Console.WriteLine("La opción no es valida...");
            break;
    }

    Console.WriteLine("PRESIONE ENTER PARA CONTINUAR..");
    Console.ReadLine();
}

