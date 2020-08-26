using LearnCore.Models.Data;
using System.Collections.Generic;

namespace LearnCore.Infrastructure
{
    internal class EmployeeDatabaseContext
    {
        List<Employee> _employeeList;
        public EmployeeDatabaseContext()
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Mayur", Email = "mayur.sapaliga@gmail.com", Department = Dept.IT },
                new Employee { Id = 2, Name = "Nikita", Email = "nikita.palta@gmail.com", Department = Dept.Finance }
            };
        }
    }
}