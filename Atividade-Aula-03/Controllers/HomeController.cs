using System.Diagnostics;
using Atividade_Aula_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_Aula_03.Controllers
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

        [HttpGet]
        public string diasSemana(int x)
        {
            string retorno = string.Empty;

            string[] days = {"sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday"};

            if (x < 7)
                retorno = days[x];
            else
                retorno = "Número inválido!";
            

            return retorno;
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
