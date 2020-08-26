using LearnCore.Models.Data;
using LearnCore.Models.Employees;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnCore.Controllers.Employees
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult ListEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            // return View("ListEmployees");
            return Content("ListEmployees");
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            var emp = _employeeService.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            var employees = _employeeService.GetAllEmployees();
            return View("ListEmployees", employees);
        }
    }
}
