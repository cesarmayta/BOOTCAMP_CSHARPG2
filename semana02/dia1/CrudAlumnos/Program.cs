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
            MostrarTitulo("[2] ACTUALIZAR ALUMNOS");
            Console.WriteLine("INGRESE EL EMAIL DEL ALUMNO A ACTUALIZAR : ");
            string emailBusqueda = Console.ReadLine();
            int posicionActualizar = listaAlumnos.FindIndex(a => a["email"] == emailBusqueda);
            if(posicionActualizar == -1)
            {
                Console.Clear();
                MostrarTitulo("NO SE ENCONTRO EL ALUMNO ...");
            }
            else
            {
                Console.WriteLine($"ALUMNO A ACTUALIZAR : {listaAlumnos[posicionActualizar]["nombre"]}");
                Console.WriteLine("INGRESE NUEVOS DATOS PARA EL ALUMNO");
                Console.WriteLine("PRESIONE ENTER SI NO DESEA ACTUALIZAR EL DATO ...");
                
                Console.WriteLine($"NOMBRE ({listaAlumnos[posicionActualizar]["nombre"]}) : ");
                string nombreActualizar = Console.ReadLine();
                if (string.IsNullOrEmpty(nombreActualizar)) nombreActualizar = listaAlumnos[posicionActualizar]["nombre"];

                Console.WriteLine($"EMAIL ({listaAlumnos[posicionActualizar]["email"]}) : ");
                string emailActualizar = Console.ReadLine();
                if (string.IsNullOrEmpty(emailActualizar)) emailActualizar = listaAlumnos[posicionActualizar]["email"];

                Console.WriteLine($"CELULAR ({listaAlumnos[posicionActualizar]["celular"]}) : ");
                string celularActualizar = Console.ReadLine();
                if (string.IsNullOrEmpty(celularActualizar)) celularActualizar = listaAlumnos[posicionActualizar]["celular"];

                listaAlumnos[posicionActualizar] = new Dictionary<string, string>
                {
                    {"nombre", nombreActualizar },
                    {"email", emailActualizar},
                    {"celular",celularActualizar }
                };
                MostrarTitulo("ALUMNO ACTUALIZADO CON EXITO");
                System.Threading.Thread.Sleep(1000);
            }
            break;
        case 4:
            MostrarTitulo("[2] ELIMINAR ALUMNO");
            Console.WriteLine("INGRESE EL EMAIL DEL ALUMNO A ELIMINAR : ");
            string emailEliminar = Console.ReadLine();
            int posicionEliminar = listaAlumnos.FindIndex(a => a["email"] == emailEliminar);
            if (posicionEliminar == -1)
            {
                Console.Clear();
                MostrarTitulo("NO SE ENCONTRO EL ALUMNO ...");
            }
            else
            {
                listaAlumnos.RemoveAt(posicionEliminar);
                MostrarTitulo("ALUMNO ELIMINADO !!!");
                System.Threading.Thread.Sleep(1000);
            }
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