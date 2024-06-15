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

        private void mostrarMensaje(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(new string('*', ANCHO));
            Console.WriteLine(new string(' ', 15) + mensaje);
            Console.WriteLine(new string('*', ANCHO));
            System.Threading.Thread.Sleep(1000);
        }
        public void MostrarMenuPrincipal()
        {
            int opcion = 0;
            while (opcion != 5)
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

                switch (opcion)
                {
                    case 1:
                        crud.RegistrarAlumno();
                        mostrarMensaje("ALUMNO REGISTRADO CON EXITO!!!");
                        break;
                    case 2:
                        crud.MostrarAlumnos();
                        Console.WriteLine("PRESIONE ENTER PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        crud.ActualizarAlumno();
                        mostrarMensaje("ALUMNO ACTUALIZADO CON EXITO !!!");
                        break;
                    case 4:
                        crud.EliminarAlumno();
                        mostrarMensaje("ALUMNO ELIMINADO CON EXITO !!!");
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA ... ");
                        break;
                    default:
                        mostrarMensaje("OPCIÓN INVALIDA!!!");
                        break;
                }
            }
        }
    }
}
