using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gun_Identification_App.Data;

namespace Gun_Identification_App.Controllers
{
    public class MainController : Controller
    {
        private readonly DBContext _context;

        public MainController(DBContext context)
        {
            _context = context;
        }

        public IActionResult GunView(string gun) 
        {

            var random = new Random();
            int randId = random.Next(1, 296);

            if (gun == "handguns")
            {
                var name = (from z in _context.Handguns
                           where z.Id == randId
                           select z.Name).FirstOrDefault().ToString();

                var image = (from z in _context.Handguns
                            where z.Id == randId
                            select z.Image).FirstOrDefault().ToString();

                ViewBag.image = image;
                ViewBag.name = name;
            }

            return View();
        }

        public async Task<IActionResult> GunQuiz(string gun)
        {
            return _context.Handguns != null ?
                        View(await _context.Handguns.ToListAsync()) :
                        Problem("Entity set 'DBContext.Handguns'  is null.");
        }


    }
}
