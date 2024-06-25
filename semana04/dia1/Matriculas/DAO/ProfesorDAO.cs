using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matriculas.INTEFACES;
using Matriculas.MODELS;

namespace Matriculas.DAO
{
    internal class ProfesorDAO : DAO<Profesor>
    {

        public Profesor FindValue(string valorBusqueda)
        {   
            Profesor profesor = this.items.Find(a => a.Email.Equals(valorBusqueda, StringComparison.OrdinalIgnoreCase));
            return profesor;
        }
        
    }
}
