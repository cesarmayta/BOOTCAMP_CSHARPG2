using Matriculas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class AlumnoUI: UI
    {
        private AlumnoDAO dao = new AlumnoDAO();


        public override void MostrarManu()
        {
            int opcion = 0;
            while(opcion != 5)
            {
                Console.Clear();
                this.mensaje.mostrarTitulo("MANTENIMIENTO DE ALUMNOS");
                Console.WriteLine(@"
                [1] REGISTRAR
                [2] MOSTRAR
                [3] ACTUALIZAR
                [4] ELIMINAR
                [5] SALIR
                ");
                this.mensaje.mostrarTitulo("INGRESE UNA OPCIÓN DEL MENU");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        dao.Create();
                        break;
                    case 2:
                        dao.Read();
                        this.mensaje.mostrarMensaje("PRESIONE UNA TECLA PARA CONTINUAR...");
                        break;
                    case 3:
                        break;
                    case 4:
                        break
                    case 5:
                        this.mensaje.mostrarMensaje("SALIENDO DEL SISTEMA");
                        break;
                    default:
                        this.mensaje.mostrarMensaje("OPCION NO VALIDA");
                        break;
                }
            }
        }
    }
}
