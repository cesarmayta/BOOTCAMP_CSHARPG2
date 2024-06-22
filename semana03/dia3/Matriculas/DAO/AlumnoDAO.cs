using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matriculas.MODELS;

namespace Matriculas.DAO
{
    internal class AlumnoDAO : DAO
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();

        public override void Create()
        {
            this.mensaje.mostrarTitulo("REGISTRO DE NUEVO PROFESOR");
            Console.WriteLine("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("NOTA : ");
            int nota = int.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno(id, nombre, email, nota);
            listaAlumnos.Add(nuevoAlumno);
            this.mensaje.mostrarMensaje("REGISTRO EXITOSO");
        }

        public override void Read()
        {
            this.mensaje.mostrarTitulo("RELACIÓN DE ALUMNOS");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }

        public override void Update() 
        { 
        }

        public override void Delete() 
        { 
        }


    }
}
