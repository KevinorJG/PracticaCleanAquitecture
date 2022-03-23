using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public abstract class BaseRepository<T> : IModel<T>
    {
        public List<T> data;
        public BaseRepository()
        {
            data = new List<T>();
        }


        public void Add(T t)
        {
            data.Add(t);
        }

        public void Delet(T t)
        {
            data.Remove(t);
        }

        public IReadOnlyList<T> Read()
        {
            return data;
        }
    }
}
