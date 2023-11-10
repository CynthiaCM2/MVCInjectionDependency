using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCInjectionDependency.Models;

namespace MVCInjectionDependency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Models.SC_TiendaContext _db;
        public HomeController(ILogger<HomeController> logger, Models.SC_TiendaContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var lst = _db.Clientes.ToList();

            return View(lst);
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