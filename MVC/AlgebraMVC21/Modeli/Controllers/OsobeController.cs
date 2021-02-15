﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modeli.Models;

namespace Modeli.Controllers
{
    public class OsobeController : Controller
    {
        // GET: Osobe
        public ViewResult PopuniOsobu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult PrikaziOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}