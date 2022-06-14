using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<Project> GetProjects()
        {
            return new List<Project>() { new Project
            {
                Title = "Proyecto 1",
                Description = "Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/270404/pexels-photo-270404.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },
            new Project
            {
                Title = "Proyecto 2",
                Description = "Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/270348/pexels-photo-270348.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },

            new Project
            {
                Title = "Proyecto 3",
                Description = "Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/270360/pexels-photo-270360.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },

            new Project
            {
                Title = "Proyecto 4",
                Description = "Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/2004161/pexels-photo-2004161.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },

            };
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