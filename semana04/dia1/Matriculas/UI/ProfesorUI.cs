using Matriculas.DAO;
using Matriculas.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class ProfesorUI : UI
    {
        private ProfesorDAO dao = new ProfesorDAO();
        private string emailBusqueda = "";
        public ProfesorUI()
        {
            dao = new ProfesorDAO();
        }

        public override void MostrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                base.mensaje.mostrarTitulo("MANTENIMIENTO DE PROFESORES");
                Console.WriteLine(@"
                    [1] REGISTRAR PROFESOR
                    [2] MOSTRAR PROFESORES
                    [3] ACTUALIZAR PROFESOR
                    [4] ELIMINAR PROFESOR
                    [5] SALIR
                ");
                base.mensaje.mostrarTitulo("INGRESE UNA OPCIÓN DEL MENU: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        this.mensaje.mostrarTitulo("REGISTRO DE NUEVO PROFESOR");

                        Console.WriteLine("ID : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("NOMBRE : ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("EMAIL : ");
                        string email = Console.ReadLine();
                        Console.WriteLine("ESPECIALIDAD : ");
                        string especialidad = Console.ReadLine();

                        Profesor nuevoProfesor = new Profesor(id, nombre, email, especialidad);
                        dao.Create(nuevoProfesor);
                        this.mensaje.mostrarMensaje("PROFESOR REGISTRADO CON EXITO!!");
                        break;
                    case 2:
                        this.mensaje.mostrarTitulo("RELACIÓN DE PROFESORES");
                        dao.Read();
                        Console.WriteLine("PRESIONE ENTER PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        this.mensaje.mostrarTitulo("ACTUALIZAR PROFESOR");
                        Console.WriteLine($"INGRESE EL EMAIL DEL PROFESOR : ");
                        this.emailBusqueda = Console.ReadLine();
                        Profesor profesor = dao.FindValue(emailBusqueda);

                        if (profesor != null)
                        {
                            Console.WriteLine("NUEVO NOMBRE : ");
                            string nuevoNombre = Console.ReadLine();
                            Console.WriteLine("NUEVO EMAIL : ");
                            string nuevoEmail = Console.ReadLine();
                            Console.WriteLine("NUEVA ESPECIALIDAD : ");
                            string nuevaEspecialidad = Console.ReadLine();

                            profesor.Nombre = nuevoNombre;
                            profesor.Email = nuevoEmail;
                            profesor.Especialidad = nuevaEspecialidad;

                            dao.Update(profesor);

                            this.mensaje.mostrarMensaje("PROFESOR ACTUALIZADO CON EXITO !!!");

                        }
                        else
                        {
                            this.mensaje.mostrarMensaje("PROFESOR NO ENCONTRADO ....");
                        }
                        break;
                    case 4:
                        this.mensaje.mostrarTitulo("ELIMINAR PROFESOR");
                        Console.WriteLine($"INGRESE EL EMAIL DEL PROFESOR : ");
                        this.emailBusqueda = Console.ReadLine();
                        Profesor profesorEliminar = dao.FindValue(this.emailBusqueda);
                        if (profesorEliminar != null)
                        {
                            dao.Delete(profesorEliminar);
                            this.mensaje.mostrarMensaje("PROFESOR ELIMINADO CON EXITO !!!");
                        }
                        else
                        {
                            this.mensaje.mostrarMensaje("PROFESOR NO ENCONTRADO ....");
                        }
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA ... ");

                        break;
                    default:
                        base.mensaje.mostrarMensaje("OPCIÓN INVALIDA!!!");
                        break;
                }
            }
        }
    }
}
