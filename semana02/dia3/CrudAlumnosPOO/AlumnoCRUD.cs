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
            Console.WriteLine("REGISTRAR ALUMNO");
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("CELULAR : ");
            string celular = Console.ReadLine();

            Alumno nuevoAlumno = new Alumno(nombre,email, celular);
            listaAlumnos.Add(nuevoAlumno);
        }

        private Alumno buscarAlumno(string opcion)
        {
            Console.WriteLine($" {opcion} ALUMNO");
            Console.WriteLine($"INGRESE EL EMAIL DEL ALUMNO A {opcion}: ");
            string email = Console.ReadLine();

            Alumno alumno = listaAlumnos.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            return alumno;
        }

        public void ActualizarAlumno()
        {
            Alumno alumno = this.buscarAlumno("ACTUALIZAR");
            if(alumno != null)
            {
                Console.WriteLine("NUEVO NOMBRE : ");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL : ");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVO CELULAR : ");
                string nuevoCelular = Console.ReadLine();

                alumno.Nombre = nuevoNombre;
                alumno.Email = nuevoEmail;
                alumno.Celular = nuevoCelular;
            }
            else
            {
                Console.WriteLine("ALUMNO NO ENCONTRADO...");
            }
        }

        public void EliminarAlumno()
        {
            Alumno alumno = this.buscarAlumno("ELIMINAR");
            if (alumno != null)
            {
                listaAlumnos.Remove(alumno);
            }
            else
            {
                Console.WriteLine("ALUMNO NO ENCONTRADO ...");
            }
        }
    }
}
