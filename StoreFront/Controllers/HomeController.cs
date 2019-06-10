using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Models;

namespace StoreFront.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "RacerXX14: Chief Technologist";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "RacerXX14 Computer Solutions, LLC";

            return View();
        }

        public IActionResult Custom()
        {
            

            var valueSeries = new Custom
            {
                CPU = "Intel 9500K",
                GPU = "Nvidia 1660ti",
                Case = "Corsiar Carbide SPEC-01",
                Cooling = "Cooler Master Big Air"
            };

            return View("Custom", valueSeries);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
