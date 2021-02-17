using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_1_vj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int rezultat = 4 + 3 * 3;
            string poruka = $"Rezultat operacije 4 + 3 * 3 = {rezultat}";
            return View((object)poruka);
        }
    }
}