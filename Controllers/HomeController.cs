using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_TacoCat.Models;

namespace MVC_TacoCat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Code()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Solve()
        {
            ViewData["ReverseWord"] = "";
            ViewData["OtherWord"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Solve(string theWord, string anotherWord)
        {
            if (string.IsNullOrWhiteSpace(theWord) || string.IsNullOrWhiteSpace(anotherWord))
            {
                return View();
            }
            var result = theWord.ToLower().Replace(" ", "");
            
            var reverse = string.Join("", result.Reverse().ToArray());
            ViewData["ReverseWord"] = reverse;           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
