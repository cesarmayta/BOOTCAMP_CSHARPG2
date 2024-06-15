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

    }
}
