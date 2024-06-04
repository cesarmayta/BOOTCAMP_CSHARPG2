/*
 PROGRAMA PARA OPERACIONES MATEMATICAS
1 - DATOS DE ENTRADA
2 - PROCESO
3 - DATOS DE SALIDA
/*
 * CONDICIONALES 
 * if(operador == "suma")
{
    resultado = a + b;
    
}
else if(operador == "resta")
{
    resultado = a - b;
}
else
{
    Console.WriteLine("No existe operador");
    return;
}
//SUMAR 2 NÚMEROS
*/
bool salir = false;
while (salir == false)
{
    //1 ENTRADA
    Console.WriteLine("Ingrese el primer número : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número : ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el tipo de operación(suma,resta,multiplicacion,division)");
    string? operador = Console.ReadLine();

    int resultado = 0;
    string simbolo = "";

    //2 PROCESO

    switch (operador)
    {
        case "suma":
            resultado = a + b;
            simbolo = " + ";
            break;
        case "resta":
            resultado = a - b;
            simbolo = " - ";
            break;
        case "multiplicacion":
            resultado = a * b;
            simbolo = " x ";
            break;
        case "division":
            resultado = a / b;
            simbolo = " / ";
            break;
        default:
            Console.WriteLine("No existe operador");
            return;
    }

    //3 SALIDA
    Console.WriteLine($"La {operador} de {a} {simbolo} {b} es {resultado}");
    
    Console.WriteLine("desea continuar (si,no) : ");
    string? valorContinuar = Console.ReadLine();
    if(valorContinuar == "no")
    {
        salir = true;
    }
}



