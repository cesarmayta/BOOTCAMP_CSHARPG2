using Matriculas.INTEFACES;
using Matriculas.MODELS;
using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal abstract class DAO<T> : ICrud<T>
    {
        protected Mensaje mensaje = new Mensaje(50);
        protected List<T> items = new List<T>();

        public virtual void Create(T item) { 
            items.Add(item);
        }

        public virtual void Read()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public virtual void Update(T item) { 
        
        }

        public virtual void Delete(T item)
        {
            items.Remove(item);
        }



    }
}
