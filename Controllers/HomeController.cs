using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        UniversityDbContext dbContext;
        

        public HomeController(UniversityDbContext context)
        {
            dbContext = context;
        }


        private readonly IConfiguration _configuration;




        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Content()
        {
            return View();
        }




        [HttpPost]
        public IActionResult Data(BigModel bm)
        {
            dbContext.AddRange(bm.Campus);
            dbContext.AddRange(bm.Department);
            dbContext.AddRange(bm.Student);

            dbContext.SaveChanges();
            ModelState.Clear();
            return View("Content");

        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return base.View(new Models.Models { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}