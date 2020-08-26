using LearnCore.Models.Data;
using System.Collections.Generic;
using System.Linq;

namespace LearnCore.Models.Employees
{
    public class EmployeeService : IEmployeeService
    {
        List<Employee> _employeeList;
        public EmployeeService()
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Mayur", Email = "mayur.sapaliga@gmail.com", Department = Dept.IT },
                new Employee { Id = 2, Name = "Nikita", Email = "nikita.palta@gmail.com", Department = Dept.Finance }
            };
        }
        public void AddEmployee(Employee emp)
        {
            _employeeList.Add(emp);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _employeeList.ForEach(x =>
            {
                if (x.Id == employee.Id)
                {
                    x.Name = employee.Name;
                    x.Email = employee.Email;
                    x.Department = employee.Department;
                }
            });

            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            return _employeeList.Remove(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
