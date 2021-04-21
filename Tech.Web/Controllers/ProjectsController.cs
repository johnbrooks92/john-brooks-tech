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
                Name = "Nemesis Engage",
                Description = "Turn-based fighting system demo created utilizing HTML, CSS, JS and jQuery. 2.0 version includes expanded roster from 2 to 30 characters and utilizing JSON object for enhanced fighting mechanics.",
                Type = "Video Game",
                Creator = "John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Name = "Six Degrees of Sandler",
                Description = "An API-AJAX Request project utilizing Glitch and a custom-made database we tailored to be Adam Sandler-themed!",
                Type = "API Data Render",
                Creator = "Christian Parker, John Brooks"

            });
            
            vm.Projects.Add(new Project()
            {
                Name = "Helping Hands",
                Description = "Capstone project rendered utilizing SpringBoot, Java, Spring Security, Thymleaf and SASS/SCSS for styling.",
                Type = "Donation Forum/Database Rendering",
                Creator = "Lening Rodas, Christian Parker, Evan Mead, John Brooks"

            });            

            vm.Projects.Add(new Project()
            {
                Name = "Boom! Roasted.",
                Description = "Object-based local data project to render coffee selections and purchase items via cart utilizing HTML/CSS/JS/Bootstrap",
                Type = "Cart Creation/Object-Based Rendering",
                Creator = "Connor Wulf, John Brooks"

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
