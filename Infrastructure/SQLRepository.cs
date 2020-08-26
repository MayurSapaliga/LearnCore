using LearnCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Infrastructure
{
    public class SQLRepository<T> : IRepository<T>
    {

        private AppDbContext _appDbContext { get; }

        public SQLRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public T Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            _appDbContext.Employees.Find(id);
            throw new NotImplementedException();
        }

        public T Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
