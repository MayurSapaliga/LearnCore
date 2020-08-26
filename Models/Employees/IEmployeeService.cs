using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnCore.Models.Data;

namespace LearnCore.Models.Employees
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);
        public void AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public bool DeleteEmployee(int id);
    }
}
