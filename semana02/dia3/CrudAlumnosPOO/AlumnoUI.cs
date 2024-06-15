using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAlumnosPOO
{
    internal class AlumnoUI
    {
        const int ANCHO = 50;
        private AlumnoCRUD crud;

        public AlumnoUI()
        {
            crud = new AlumnoCRUD();
        }

        private void mostrarTitulo(string titulo)
        {
            Console.WriteLine(new string('=', ANCHO));
            Console.WriteLine(new string(' ', 15) + titulo);
            Console.WriteLine(new string('=', ANCHO));
        }
        public void MostrarMenuPrincipal()
        {
            int opcion = 0;
            while(opcion != 5)
            {
                Console.Clear();
                this.mostrarTitulo("CRUD DE ALUMNOS");
                Console.WriteLine(@"
                    [1] REGISTRAR ALUMNO
                    [2] MOSTRAR ALUMNOS
                    [3] ACTUALIZAR ALUMNO
                    [4] ELIMINAR ALUMNO
                    [5] SALIR
                ");
                this.mostrarTitulo("INGRESE UNA OPCIÓN DEL MENU: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"ELEGISTE OPCIÓN {opcion}");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
