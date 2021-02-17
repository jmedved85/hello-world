using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_1_vj.Controllers
{
    public class KontekstController : Controller
    {
        // GET: Kontekst
        public string Index()
        {
            string serverName = Server.MachineName;
            string trenutniDatum = DateTime.Now.ToLongDateString();
            string poruka = $"Trenutni datum je {trenutniDatum}, a računalo je {serverName}.";
            return poruka;
        }

        public string
    }
}