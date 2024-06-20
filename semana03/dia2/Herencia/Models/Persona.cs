using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Persona
    {
        private string nombre { get; set; }
        private string email {  get; set; }

        public Persona(string nombre,string email)
        {
            this.nombre = nombre;
            this.email = email;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"NOMBRE : {this.nombre}");
            Console.WriteLine($"EMAIL : {this.email}");
        }
    }
}
