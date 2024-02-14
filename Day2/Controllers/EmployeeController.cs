using Day2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class EmployeeController : Controller
    {
        private TaskContext context;
        public EmployeeController()
        {
            context = new TaskContext();    
        }
        public IActionResult Index()

        {
            List<Employee> list = context.Employees.ToList();
            return View(list);
        }
        public IActionResult Details(int id)
        {
            Employee employee = context.Employees.SingleOrDefault(e=>e.SSN == id);
            return View(employee);
        }
    }
}
