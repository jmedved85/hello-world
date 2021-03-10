using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Seminari.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Seminari.Controllers
{
    public class HomeController : Controller
    {
        private readonly Baza_SeminariContext _context;

        public HomeController(Baza_SeminariContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync(string pretraga)
        {
            var rezultat = from r in _context.Seminars
                           select r;

            if (!string.IsNullOrEmpty(pretraga))
            {
                rezultat = rezultat.Where(p => p.Naziv.Contains(pretraga));
            }

            return View(await rezultat.ToListAsync());           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
