using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.INTEFACES
{
    internal interface ICrud<T>
    {
        public  void Create(T item);
        public  void Read();
        public  void Update(T item);
        public  void Delete(T item);
    }
}
