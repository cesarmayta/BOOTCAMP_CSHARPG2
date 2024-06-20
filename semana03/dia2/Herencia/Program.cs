using Herencia.Models;

class Program
{
    static void Main()
    {
        Alumno alumno1 = new Alumno();
        alumno1.Nombre = "César";
        alumno1.Email = "cesar@gmail.com";
        alumno1.Mostrar();

        Profesor profesor1 = new Profesor();
        profesor1.Nombre = "Laura";
        profesor1.Email = "laura@gmail.com";
        profesor1.Mostrar();
    }
}