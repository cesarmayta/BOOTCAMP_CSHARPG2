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

while(opcion < 5)
{
    Console.Clear();
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 15) + "CRUD DE ALUMNOS");
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
}