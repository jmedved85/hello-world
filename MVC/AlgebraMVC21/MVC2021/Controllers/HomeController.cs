using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC2021.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() // defaultni action/ defaultna ruta (nešto što će se pozvati kada se upiše prazno)
        {
            return View(); // odlazi u C:\Users\jmedv\source\repos\hello-world\MVC\AlgebraMVC21\MVC2021\Views\Home\Index.cshtml
        }

        public IActionResult Privacy()
        {
            return View(); // odlazi u C:\Users\jmedv\source\repos\hello-world\MVC\AlgebraMVC21\MVC2021\Views\Home\Privacy.cshtml
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
