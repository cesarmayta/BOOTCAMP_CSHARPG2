using Herencia.Models;

class Program
{
    static void Main()
    {
        Alumno alumno1 = new Alumno("cesar","cesar@gmail.com",20);
        alumno1.Mostrar();

        Console.WriteLine(new string('*', 100));

        Profesor profesor1 = new Profesor("Jorge","jorge@gmail.com");
        profesor1.Mostrar();
    }
}