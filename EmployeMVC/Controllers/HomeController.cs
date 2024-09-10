using EmployeMVC.Data;
using EmployeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseDbContext _db;

        /*  private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
        _logger = logger;
        }
        */


        public HomeController(DatabaseDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var EmployeeData = await _db.Employees.Include(e=>e.Department).Include(e=>e.Designation).ToListAsync();
            return View(EmployeeData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
