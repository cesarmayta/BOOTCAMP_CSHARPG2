//variables
//string
string nombre = "cesar";
//enteros
short edad = 40;
//Console.WriteLine("Hola mi nombre es " + nombre + " y tengo " + edad + " años");
//Console.WriteLine("Hola mi nombre es {0} y tengo {1} años", nombre, edad);
Console.WriteLine($"Hola mi nombre es {nombre} y tengo {edad} años");
Console.WriteLine("Cual es tu nombre ?");
string? nombreUsuario = Console.ReadLine();
string nombreUsuarioSinEspacios = nombreUsuario.Trim();
int cantidadLetras = nombreUsuarioSinEspacios.Replace(" ", "").Length;
Console.WriteLine($"Te llamas {nombreUsuarioSinEspacios} y tu nombre tiene {cantidadLetras} caracteres");
//decimales
float altura = 16.5f;

//fechas
DateTime fechaNacimiento = new DateTime(1990, 4, 1);
var fechaActual = DateTime.Now;

Console.WriteLine($"Mi fecha de nacimiento es : {fechaNacimiento.Date.ToString("dd/MM/yyyy")}");
Console.WriteLine($"La fecha actual es {fechaActual.Date.ToString("dd/MM/yyyy")}");

var diferenciaFechas = fechaActual - fechaNacimiento;

Console.WriteLine($"Mi edad es {diferenciaFechas.Days / 365} años");



