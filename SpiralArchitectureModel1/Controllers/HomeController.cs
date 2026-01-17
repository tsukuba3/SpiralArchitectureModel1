using Microsoft.AspNetCore.Mvc;
using SpiralArch.Models;
using SpiralArchitectureModl1.Models;
using System.Diagnostics;

namespace SpiralArchitectureModl1.Controllers
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
            // 重要：ここでインスタンスを作って渡す
            var viewModel = new PriceCalculatorViewModel();

            // モデルを引数に入れてViewに渡す
            return View(viewModel);
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
