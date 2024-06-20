using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Alumno : Persona
    {
      public int Nota { get; set; }

      public override void Mostrar()
      {
          Console.WriteLine("DATOS DEL ALUMNO : ");
          base.Mostrar();
          Console.WriteLine($"NOTA : {Nota}");
      }
    }
}
