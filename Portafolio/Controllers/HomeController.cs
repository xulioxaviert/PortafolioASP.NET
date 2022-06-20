using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository projectsRepository;
        private readonly IConfiguration configuration;

        public HomeController(IProjectsRepository projectsRepository)

        {

            this.projectsRepository = projectsRepository;

        }

        public IActionResult Index()

        {

            var projects = projectsRepository.GetProjects().Take(3).ToList();
            var modelo = new HomeIndexViewModel()
            {
                Projects = projects
            };


            return View(modelo);
        }


        public IActionResult Projects()
        {
            var projects = projectsRepository.GetProjects();
            return View(projects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}