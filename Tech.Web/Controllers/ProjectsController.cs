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
                Description = "Turn-based fighting system demo created utilizing HTML, CSS, JS and jQuery",
                Type = "Video Game",
                Creator = "Solo"

            });
            
            vm.Projects.Add(new Project()
            {
                Name = "Six Degrees of Sandler",
                Description = "An API-AJAX Request project utilizing Glitch and a custom-made database we tailored to be Adam Sandler-themed!",
                Type = "API Data Render",
                Creator = "Paired with Christian Parker"

            });
            
            vm.Projects.Add(new Project()
            {
                Name = "Helping Hands",
                Description = "Capstone project rendered utilizing SpringBoot, Java, Spring Security, Thymleaf and SASS/SCSS for styling.",
                Type = "Donation Forum/Database Rendering",
                Creator = "Group - Lening Rodas & Evan Mead & Christian Parker"

            });            

            vm.Projects.Add(new Project()
            {
                Name = "Boom! Roasted.",
                Description = "Object-based local data project to render coffee selections and purchase items via cart utilizing HTML/CSS/JS/Bootstrap",
                Type = "Donation Forum/Database Rendering",
                Creator = "Paired with Connor Wulf"

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
