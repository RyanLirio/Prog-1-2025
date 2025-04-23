using System.Diagnostics;
using AULA04recursividade.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA04recursividade.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public string PrintNaturalFor(int n = 10)
        {
            string retorno = string.Empty;

            int i = 1;
            while (i <= n)//flag
            {
                retorno += $" {i} ";//acumulador
                i++;
            }

            return retorno;
        }

        [HttpGet]
        public string PrintNaturalRecursion(int count = 10)
        {
            string retorno = "";

            retorno = NaturalNumberRecursion(1, count);

            return retorno;
        }
        public string NaturalNumberRecursion(int n, int count)
        {
            string ret = string.Empty;

            //Caso base: se o contador for menor que 1
            if(count < 1)
                return $" {n} ";

            ret += $" {count} ";
            count--; //decrementar count

            // Chamada recursiva: Incrementa n e decrementa count
            // Para imprimir o número
            ret += NaturalNumberRecursion(n + 1, count);
            return ret;
        }


    }
}
