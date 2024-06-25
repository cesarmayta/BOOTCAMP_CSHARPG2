using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.INTEFACES
{
    internal interface ICrud
    {
        public  void Create();
        public  void Read();
        public  void Update();
        public  void Delete();
    }
}
