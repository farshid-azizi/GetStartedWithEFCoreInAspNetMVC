using GetStartedWithEFCoreInAspNetMVC.Data;
using GetStartedWithEFCoreInAspNetMVC.Models;
using GetStartedWithEFCoreInAspNetMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GetStartedWithEFCoreInAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<ActionResult> About()
        {
            IQueryable<DateOfBirthGroup> data =
                from customer in _context.Customers
                group customer by customer.DateOfBirth into dateGroup
                select new DateOfBirthGroup()
                {
                    DateOfBirth = dateGroup.Key,
                    CustomerCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }
        public IActionResult Index()
        {
            return View();
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