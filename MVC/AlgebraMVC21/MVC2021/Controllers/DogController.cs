﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2021.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // http://localhost:5000/Dog/Pozdrav?NekiBroj=7
        public IActionResult Pozdrav(int NekiBroj = 1)
        {
            // neke varijable koje bacamo na view
            ViewData["Poruka"] = "Uplati mi na račun";
            ViewData["NekiBroj"] = NekiBroj;

            string model = "Pozdrav svijete iz MVC-a!";
            return View((object)model); //Views/Dog/Pozdrav.cshtml
        }

        // http://localhost:5000/Dog/Ola?NekiBroj=7
        public IActionResult Ola(int NekiBroj = 1)
        {
            //// neke varijable koje bacamo na view
            //ViewData["Poruka"] = "Uplati mi na račun";
            //ViewData["NekiBroj"] = NekiBroj;

            // string olaPozdrav = "Pozdrav svijete iz MVC-a! Unešeni broj je " + NekiBroj;
            string olaPozdrav = "<p> neki text</p>";
            return Content(olaPozdrav, "text/xml"); 
        }

    }
}
