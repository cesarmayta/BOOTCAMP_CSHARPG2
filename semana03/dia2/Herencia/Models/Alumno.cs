using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Alumno : Persona
    {
      private int nota { get; set; }

      public Alumno(string nombre,string email,int nota) : base(nombre, email) {
          this.nota = nota;
      }

      public override void Mostrar()
      {
          Console.WriteLine("DATOS DEL ALUMNO : ");
          base.Mostrar();
          Console.WriteLine($"NOTA : {this.nota}");
      }
    }
}
