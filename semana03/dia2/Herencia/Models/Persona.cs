using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Email {  get; set; }

        public Persona()
        {

        }

        public void Mostrar()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"NOMBRE : {Nombre}");
            Console.WriteLine($"EMAIL : {Email}");
        }
    }
}
