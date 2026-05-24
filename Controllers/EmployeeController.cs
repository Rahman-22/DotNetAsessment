using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotNetAsessment.Models;

namespace DotNetAsessment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var filteredEmployees = _db.Employees
                .Where(e => (e.EmployeeName.StartsWith("A") || 
                             e.EmployeeName.StartsWith("G") || 
                             e.EmployeeName.StartsWith("V")) 
                         && (e.BirthDate.Month >= 1 && e.BirthDate.Month <= 3))
                .ToList();

            return View(filteredEmployees);
        }
    }
}