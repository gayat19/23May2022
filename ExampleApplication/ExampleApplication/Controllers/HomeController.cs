using ExampleApplication.Models;
using ExampleApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISample _sample;

        public HomeController(ILogger<HomeController> logger,ISample sample)
        {
            _logger = logger;
            _sample = sample;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index method invoked");
            try
            {
                var result = _sample.CheckNumber(int.MaxValue);
                ViewBag.Result = result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message+" "+DateTime.Now.ToShortDateString());
            }
            return View();
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
