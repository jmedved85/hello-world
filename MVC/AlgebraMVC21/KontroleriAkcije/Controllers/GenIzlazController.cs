using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KontroleriAkcije.Controllers
{
    public class GenIzlazController : Controller
    {
        // GET: GenIzlaz
        public ViewResult Index()
        {
            ViewBag.Vrijeme = DateTime.Now;
            return View("PrimjerPogleda");
        }
        public RedirectResult Redirekt()
        {
            return Redirect("/Prvi/Pozdrav");
        }
        public RedirectToRouteResult Redirekt2()
        {
            return RedirectToAction("Pozdrav", "Prvi");
        }

    }
}