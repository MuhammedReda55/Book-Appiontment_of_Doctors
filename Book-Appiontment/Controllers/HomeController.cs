using System.Diagnostics;
using Book_Appiontment.Data;
using Book_Appiontment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Appiontment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplacationDbContext _context = new ApplacationDbContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hospital()
        {
            var doctor = _context.Doctors.ToList();
            return View(doctor);

            
        }
        public IActionResult Details(int DoctorId)
        {
            var doctor = _context.Doctors.Find(DoctorId);
            if (doctor != null) return View(doctor);

            return RedirectToAction("NotFoundPage");
        }

        public IActionResult NotFoundPage()
        {
            return View();
        }
        public IActionResult Modal()
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
