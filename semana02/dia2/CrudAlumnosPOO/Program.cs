namespace CrudAlumnosPOO
{
    class Program
    {
        
        const int ANCHO = 50;
        
        static void Main()
        {
            int opcion = 0;
            List<Alumno> listaAlumnos = new List<Alumno>()
            {
                new Alumno("César Mayta","cesar@gmail.com","234234")
            };

            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine(new string('=', ANCHO));
                Console.WriteLine(new string(' ', 15) + "CRUD ALUMNOS CON POO");
                Console.WriteLine(new string('=', ANCHO));
                Console.WriteLine(@"
                         [1] REGISTRAR ALUMNO
                         [2] MOSTRAR ALUMNOS
                         [3] ACTUALIZAR ALUMNO
                         [4] ELIMINAR ALUMNO
                         [5] SALIR
                 ");
                Console.WriteLine(new string('=', ANCHO));
                Console.WriteLine("INGRESE UNA OPCIÓN DEL MENU: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("[1] REGISTRAR ALUMNO");
                        Console.WriteLine("NOMBRE : ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("EMAIL : ");
                        string email = Console.ReadLine();
                        Console.WriteLine("CELULAR : ");
                        string celular = Console.ReadLine();

                        Alumno nuevoAlumno = new Alumno(nombre, email, celular);
                        listaAlumnos.Add(nuevoAlumno);
                        Console.Clear();
                        Console.WriteLine("ALUMNO REGISTRADO CON EXITO ...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case 2:
                        foreach(var alumno in listaAlumnos)
                        {
                            Console.WriteLine(new string('*', ANCHO));
                            alumno.Mostrar();
                        }
                        Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR ...");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA");
                        break;
                    default:
                        Console.WriteLine("OPCIÓN INVALIDA!!!");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}