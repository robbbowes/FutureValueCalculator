using FutureValueCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValueCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel futureValueModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = futureValueModel.Calculate().ToString("c2");
            }
            else
            {
                ViewBag.FutureValue = "";
            }
            return View();
        }
    }
}