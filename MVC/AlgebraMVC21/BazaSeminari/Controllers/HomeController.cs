using BazaSeminari.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BazaSeminari.Controllers
{
    public class HomeController : Controller
    {
        private readonly Baza_SeminariContext _context;

        public HomeController(Baza_SeminariContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Seminars.ToListAsync());
        }

        //public IActionResult Pretraga()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
