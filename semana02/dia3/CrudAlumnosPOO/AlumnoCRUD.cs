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
    }
}
