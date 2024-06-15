using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAlumnosPOO;

namespace CrudAlumnosPOO
{
    internal class AlumnoCRUD
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();

        public AlumnoCRUD()
        {
            Alumno alumnoMuestra = new Alumno("César Mayta", "cesar@gmail.com", "82372323");
            listaAlumnos.Add(alumnoMuestra);
        }

        public void MostrarAlumnos()
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string(' ', 20) + "LISTADO DE ALUMNOS");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }

        public void RegistrarAlumno()
        {
            Console.WriteLine("[1] REGISTRAR ALUMNO");
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("CELULAR : ");
            string celular = Console.ReadLine();

            Alumno nuevoAlumno = new Alumno(nombre,email, celular);
            listaAlumnos.Add(nuevoAlumno);
        }
    }
}
