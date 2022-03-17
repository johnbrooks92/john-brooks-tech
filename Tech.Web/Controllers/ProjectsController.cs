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
                Description = "Capstone project rendered utilizing SpringBoot, Java, Spring Security, Thymeleaf and SASS/SCSS for styling.",
                Type = "Donation Forum/Database Rendering",
                Creator = "Lening Rodas, Christian Parker, Evan Mead, John Brooks"

            });            

            vm.Projects.Add(new Project()
            {
                Route = "/weathermap/weather_map.html",
                Name = "WeatherNova",
                Description = "Weather app made using API calls to the OpenWeatherMap API; Rendering instant 7-day forecast upon location selection as well as a geomap to visually represent the data.",
                Type = "API Calls and MapRendering",
                Creator = "John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Route = "/nemesis-engage-2/index.html",
                Name = "Nemesis Engage 2",
                Description = "Turn-based fighting system demo created utilizing HTML, CSS, JS and jQuery. 2.0 version includes expanded roster from 2 to 30 characters and utilizing JSON object for enhanced fighting mechanics.",
                Type = "Video Game",
                Creator = "John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Route = "/pizza-app/order-pizza.html",
                Name = "Pizza Ordering App",
                Description = "Pizza ordering app built using fully-static structure of HTML, CSS, and JS.",
                Type = "Static Ordering Cart",
                Creator = "John Brooks"

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
