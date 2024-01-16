using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MathController : Controller
    {
        [ApiController]
        [Route("api/{controller}")]
        public IActionResult Add([FromQuery] int x, [FromQuery] int y) {
            int sum = x + y;
            return Ok(sum);
        }
        [ApiController]
        [Route("api/{controller}")]
        public IActionResult Multiply([FromQuery] int x, [FromQuery] int y) {
            int sum = x * y;
            return Ok(sum);
        }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/info")]
        public IActionResult About(string name)
        {
            ViewBag.Name = name;
            return View();
        }
        [HttpGet]
        [Route("/Home/Greet/{name}")]
        public IActionResult Greet([FromQuery] string name)
        {
            ViewBag.Name = name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
