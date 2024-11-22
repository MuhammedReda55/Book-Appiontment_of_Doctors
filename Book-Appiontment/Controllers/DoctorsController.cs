using Book_Appiontment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_Appiontment.Controllers
{
    public class DoctorsController : Controller
    {
        private ApplacationDbContext _context = new ApplacationDbContext();
        public IActionResult Index()
        {
            var list = _context.lists.ToList();
            return View(list);
        }

        public IActionResult list( string PatientName, DateOnly AppiontmenDate,
            TimeOnly AppiontmenTime, string dotorname)
        {
            _context.lists.Add(new()
            {
               NameDoctor= dotorname,
                NamePatient = PatientName,
                AppiontmenDate = AppiontmenDate,
                AppiontmenTime = AppiontmenTime
            });
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
