using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Profesor : Persona
    {
        private string especialidad;

        public Profesor(int id,string nombre,string email,string especialidad) : base(id, nombre, email)
        {
            this.especialidad = especialidad;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"ESPECIALIDAD : {this.especialidad}");
        }
    }
}
