//Tipos de dato
var nombreDinamico = "César Mayta";
var edadDinamica = 40;

//tipado estatico
string nombre;
int edad;
float sueldo;
bool esCasado;
int calificacion = 0;

Console.WriteLine("Ingresa tu edad : ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine($"tu edad es {edad}");

//evaluar si es mayor de edad
// se considera mayor de edad si tiene 18 años o mas

if(edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}

Console.WriteLine("Ingresa tu calificación : ");
calificacion = int.Parse(Console.ReadLine());

if(calificacion < 11)
{
    Console.WriteLine("Estas desaprobado");
}
else if(calificacion >= 11 && calificacion <= 15)
{
    Console.WriteLine("aprobaste con nota aceptable");
}
else if(calificacion > 15)
{
    Console.WriteLine("Tu nota es excelente");
}

Console.WriteLine("Ingresa el día de la semana");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Es Lunes");
        break;
    case 2:
        Console.WriteLine("Es Martes");
        break;
    case 3:
        Console.WriteLine("Es Miercoles");
        break;
    case 4:
        Console.WriteLine("Es jueves");
        break;
    case 5:
        Console.WriteLine("Es Viernes");
        break;
}
