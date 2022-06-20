using Portafolio.Models;

namespace Portafolio.Services
{

    public interface IProjectsRepository
    {
        List<Project> GetProjects();
    }

    public class ProjectsRepository: IProjectsRepository
    {
        public List<Project> GetProjects()
        {
            return new List<Project>() {
            new Project
            {
                Title = "Proyecto 1",
                Description = "Proyecto 1 Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/270404/pexels-photo-270404.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },
            new Project
            {
                Title = "Proyecto 2",
                Description = "Proyecto 2 Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/270348/pexels-photo-270348.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },

            new Project
            {
                Title = "Proyecto 3",
                Description = "Proyecto 3 Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/270360/pexels-photo-270360.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },

            new Project
            {
                Title = "Proyecto 4",
                Description = "Proyecto 4 Web Page ASP.NET",
                Link = "htpps://www.google.es",
                ImgURL = "https://images.pexels.com/photos/2004161/pexels-photo-2004161.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },

            };
        }
    }
}
