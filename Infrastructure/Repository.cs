using LearnCore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Infrastructure
{
    public class Repository<T> : IRepository<T>
    {
        List<Employee> _employeeList;

        private readonly EmployeeDatabaseContext  _repositoryDatabaseContext;
        public Repository(IRepositoryDatabaseContext _repositoryDatabaseContext)
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Mayur", Email = "mayur.sapaliga@gmail.com", Department = Dept.IT },
                new Employee { Id = 2, Name = "Nikita", Email = "nikita.palta@gmail.com", Department = Dept.Finance }
            };
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
            throw new NotImplementedException();
        }

        public T Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
