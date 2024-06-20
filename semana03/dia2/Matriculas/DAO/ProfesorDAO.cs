using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matriculas.MODELS;
using Matriculas.UTILS;

namespace Matriculas.DAO
{
    internal class ProfesorDAO : DAO
    {
        private List<Profesor> listaProfesor = new List<Profesor>();

        public override void Create()
        {
            base.mensaje.mostrarTitulo("REGISTRO DE NUEVO PROFESOR");
            
            Console.WriteLine("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("ESPECIALIDAD : ");
            string especialidad = Console.ReadLine();

            Profesor nuevoProfesor = new Profesor(id, nombre, email, especialidad);
            listaProfesor.Add(nuevoProfesor);
            base.mensaje.mostrarMensaje("PROFESOR REGISTRADO CON EXITO!!");

        }
        public override void Read()
        {

        }
        public override void Update()
        {

        }
        public override void Delete()
        {

        }

    }
}
