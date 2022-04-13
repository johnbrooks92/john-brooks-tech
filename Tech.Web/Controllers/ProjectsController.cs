using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tech.Web.Models;

namespace Tech.Web.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var vm = new ProjectsViewModel();
            
            vm.Projects.Add(new Project()
            {
                Route = "https://sahelpinghands.org",
                Name = "Helping Hands",
                Description = "Full-Stack Capstone project rendered utilizing SpringBoot, Java, Spring Security, Thymeleaf and SASS/SCSS for styling.",
                Type = "Donation Forum/Database Rendering",
                Creator = "Lening Rodas, Christian Parker, Evan Mead, John Brooks"

            });            

            vm.Projects.Add(new Project()
            {
                Route = "/weathermap/weather_map.html",
                Name = "WeatherNova",
                Description = "Weather app made using API calls to the OpenWeatherMap API; Renders instant 7-day forecast upon location selection.",
                Type = "API Calls and MapRendering",
                Creator = "John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Route = "/nemesis-engage-2/index.html",
                Name = "NE: 2",
                Description = "Turn-based fighting system demo created utilizing HTML, CSS, JS and jQuery. Expanded roster from 2 to 30 characters utilizing JSON object for enhanced fighting mechanics.",
                Type = "Video Game",
                Creator = "John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Route = "https://github.com/SFW-FreeDevelopment/LordOfFrames",
                Name = "Lord Of Frames",
                Description = "AI Bot created for use in Discord Server using .NET 6/C#. Outputs instant data responses for real-time command requests.",
                Type = "Machine Programming",
                Creator = "Christopher Plummer, John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Route = "/movie-app/index.html",
                Name = "Six Degrees of Sandler",
                Description = "API Requests using IMDB to enable CRUD, Search functionality within local database.",
                Type = "API/Querying Functionality",
                Creator = "John Brooks, Christian Parker"
            
            });
            
            vm.Projects.Add(new Project()
            {
                Route = "/coffee-project/index.html",
                Name = "Boom! Roasted",
                Description = "Coffee Ordering Project. Michael Scott-themed.",
                Type = "Static Ordering Functionality",
                Creator = "John Brooks, Connor Wulf"
            
            });

            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
