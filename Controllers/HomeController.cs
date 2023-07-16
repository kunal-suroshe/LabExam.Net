using Microsoft.AspNetCore.Mvc;

namespace TemperatureConverter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            ViewBag.Celsius = celsius;
            ViewBag.Fahrenheit = fahrenheit;

            return View();
        }
    }
}