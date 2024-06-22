using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Persona
    {
        private int id;
        private string nombre;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }

        public Persona(int id,string nombre,string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"ID : {this.id}");
            Console.WriteLine($"NOMBRE : {this.nombre}");
            Console.WriteLine($"EMAIL : {this.email}");
        }
    }
}
