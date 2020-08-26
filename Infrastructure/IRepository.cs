using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Infrastructure
{
    interface IRepository<T>
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public T Add(T t);
        public T Update(T t);
        public void Delete(int id);
    }
}
