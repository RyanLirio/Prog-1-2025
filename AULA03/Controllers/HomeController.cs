using System.Diagnostics;
using AULA03.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public string GetIf(int x)
        {
            /*
            Estrutura suntática do IF
            if(expressão booleana)
            {
                Sentença de código a ser executada, caso a condição seja verdadeira
            }
            Caso o if tenha apenas uma linha de de comando a ser executada na condicional
            não há necessidade do uso das chaves
            sendo então:
            if(expressão booleana)
                Apenas um comando
             */
            string retorno = string.Empty;
            //int x = 10;

            if (x > 9)
                retorno = "x é maior que 9";

            
            if (x > 9)
                retorno = "x é maior que 9";
            else
                retorno = "x é menor que 9";

            //x = 11;
            if(x == 10)
            {
                retorno = "Ora ora";
                retorno += "X é igual a 10";
            }
            else if(x == 9)
            {
                retorno = "Hmmmmmmm";
                retorno += "x é igual a 9";
            }
            else if(x == 8)
            {
                retorno = "Bahhhh";
                retorno += "x é igual a 8 tchê.";
            }
            else
            {
                retorno = "Sei lá que número é x";
            }

            return retorno;
        }

        [HttpGet]
        public string GetSwitch(int x)
        {
            string retorno = string.Empty;
            switch (x)
            {
                case 0:
                    retorno = "x é zero";
                    break;
                case 1:
                    retorno = "x é um";
                    break;
                case 2:
                    retorno = "x é dois";
                    break;
                default:
                    retorno = "x é algum numero";
                    break;
            }

            return retorno;
        }

        [HttpGet]
        public string GetFor(int x)
        {
            /*
                O comando de repetição for possui a seguinte sintaxe:
                 for(<inicializador>; <expressão condicional>; <expressão de repetição>)
                 {
                     Comandos a serem executados
                 }
                 Inicializador: elemento contador. Tradicionalmente utilizado o i = indice.
                 Expressão condicional: especifica o teste a ser verificado quando o loop estiver executando o número definido de interações(flag).
                 Expressão de repetição: especifica a ação a ser executada com a variável contadora. Geralmente um acúmulo ou decrécimo(acumulador).
             */
            string retorno = string.Empty;
            for(int i = 0; i <= x; i++)
            {
                //E seu eu quisesse interromper o laço
                //caso ele fosse maior que 5
                if (i > 5)
                    break; //O comando break interrompe o laço

                // caso eu deseje que o laço siga em frente
                // forçando a continuar a execução
                if ((i % 2) != 0)
                    continue;

                retorno += $"{i}; ";
            }

            return retorno;
        }

        [HttpGet]
        public string GetForeach(string color)
        {
            string retorno = string.Empty;
            /*
                O comando foreach (para cada) é utilizada para iterar por uma sequência de itens em uma coleção e servir como uma opção simples de repetição.
                */

            string[] colors = { "Vermelho", "Preto", "Azul", "Amarelo", "Verde", "Branco", "Azul-Marinho", "Rosa", "Roxo", "Cinza" };

            if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1) ))
            {
                retorno = "A cor escolhida é válida";
            }
            else
                retorno = "Cor escolhida inválida";

            foreach (string s in colors)
            {
                retorno += $"[{s}]";
            }

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
