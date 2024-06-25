
using Matriculas.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal class AlumnoDAO : DAO<Alumno>
    {
        public Alumno FindValue(string valorBusqueda)
        {
            Alumno item = this.items.Find(a => a.Email.Equals(valorBusqueda, StringComparison.OrdinalIgnoreCase));
            return item;
        }
    }
}
