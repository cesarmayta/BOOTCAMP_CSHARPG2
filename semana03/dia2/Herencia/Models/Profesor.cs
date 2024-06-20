using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Profesor : Persona
    {
        public Profesor(string nombre,string email) : base(nombre, email) 
        { 
        }
        public override void Mostrar()
        {
            Console.WriteLine("DATOS DEL PROFESOR : ");
            base.Mostrar();
        }
    }
}
