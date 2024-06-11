List<Dictionary<string, string>> listaAlumnos = new List<Dictionary<string, string>>();
Dictionary<string, string> alumnoMuestra = new Dictionary<string, string>
{
    {"nombre","César Mayta"},
    {"email","cesar@gmail.com"},
    {"celular","992929292"}
};
listaAlumnos.Add(alumnoMuestra);

int opcion = 0;
const int ANCHO = 50;

void MostrarTitulo(string titulo)
{
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 15) + titulo);
    Console.WriteLine(new string('=', ANCHO));
}

while(opcion != 5)
{
    Console.Clear();
    MostrarTitulo("CRUD DE ALUMNOS");
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
            MostrarTitulo("[1] REGISTRAR ALUMNO");
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("CELULAR : ");
            string celular = Console.ReadLine();
            Dictionary<string, string> nuevoAlumno = new Dictionary<string, string>
            {
                {"nombre",nombre},
                {"email",email},
                {"celular",celular}
            };
            listaAlumnos.Add(nuevoAlumno);
            Console.Clear();
            MostrarTitulo("ALUMNO REGISTRADO CON EXITO...");
            System.Threading.Thread.Sleep(1000);
            break;
        case 2:
            MostrarTitulo("[2] MOSTRAR ALUMNOS");
            foreach(var alumno in listaAlumnos)
            {
               Console.WriteLine(new string('*', ANCHO));
               foreach(var dicAlumno in alumno)
                {
                    Console.WriteLine($"{dicAlumno.Key} : {dicAlumno.Value}");
                }
            }
            MostrarTitulo("PRESIONE UNA TECLA PARA CONTINUAR ...");
            Console.ReadLine();
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            MostrarTitulo("SALIENDO DEL SISTEMA");
            break;
        default:
            MostrarTitulo("OPÇIÓN INVALIDA!!!");
            System.Threading.Thread.Sleep(1000);
            break;
    }
}