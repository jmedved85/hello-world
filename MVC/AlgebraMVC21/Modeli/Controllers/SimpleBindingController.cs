using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modeli.Controllers
{
    public class SimpleBindingController : Controller
    {
        // GET: SimpleBinding
        public ViewResult SimpleBindMetoda ()
        {
            return View("SimpleBind");
        }
        [HttpPost]
        public ViewResult SimpleBindMetoda(string ime)
        {
            string pozdrav = "Pozdrav, " + ime + "!";
            return View("SimpleBind", (object)pozdrav);
        }
    }
}