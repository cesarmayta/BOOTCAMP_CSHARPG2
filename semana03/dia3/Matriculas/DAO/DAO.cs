using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal abstract class DAO
    {
        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();
       
    }
}
