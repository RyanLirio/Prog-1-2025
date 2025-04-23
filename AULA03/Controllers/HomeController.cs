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
            Estrutura sunt�tica do IF
            if(express�o booleana)
            {
                Senten�a de c�digo a ser executada, caso a condi��o seja verdadeira
            }
            Caso o if tenha apenas uma linha de de comando a ser executada na condicional
            n�o h� necessidade do uso das chaves
            sendo ent�o:
            if(express�o booleana)
                Apenas um comando
             */
            string retorno = string.Empty;
            //int x = 10;

            if (x > 9)
                retorno = "x � maior que 9";

            
            if (x > 9)
                retorno = "x � maior que 9";
            else
                retorno = "x � menor que 9";

            //x = 11;
            if(x == 10)
            {
                retorno = "Ora ora";
                retorno += "X � igual a 10";
            }
            else if(x == 9)
            {
                retorno = "Hmmmmmmm";
                retorno += "x � igual a 9";
            }
            else if(x == 8)
            {
                retorno = "Bahhhh";
                retorno += "x � igual a 8 tch�.";
            }
            else
            {
                retorno = "Sei l� que n�mero � x";
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
                    retorno = "x � zero";
                    break;
                case 1:
                    retorno = "x � um";
                    break;
                case 2:
                    retorno = "x � dois";
                    break;
                default:
                    retorno = "x � algum numero";
                    break;
            }

            return retorno;
        }

        [HttpGet]
        public string GetFor(int x)
        {
            /*
                O comando de repeti��o for possui a seguinte sintaxe:
                 for(<inicializador>; <express�o condicional>; <express�o de repeti��o>)
                 {
                     Comandos a serem executados
                 }
                 Inicializador: elemento contador. Tradicionalmente utilizado o i = indice.
                 Express�o condicional: especifica o teste a ser verificado quando o loop estiver executando o n�mero definido de intera��es(flag).
                 Express�o de repeti��o: especifica a a��o a ser executada com a vari�vel contadora. Geralmente um ac�mulo ou decr�cimo(acumulador).
             */
            string retorno = string.Empty;
            for(int i = 0; i <= x; i++)
            {
                //E seu eu quisesse interromper o la�o
                //caso ele fosse maior que 5
                if (i > 5)
                    break; //O comando break interrompe o la�o

                // caso eu deseje que o la�o siga em frente
                // for�ando a continuar a execu��o
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
                O comando foreach (para cada) � utilizada para iterar por uma sequ�ncia de itens em uma cole��o e servir como uma op��o simples de repeti��o.
                */

            string[] colors = { "Vermelho", "Preto", "Azul", "Amarelo", "Verde", "Branco", "Azul-Marinho", "Rosa", "Roxo", "Cinza" };

            if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1) ))
            {
                retorno = "A cor escolhida � v�lida";
            }
            else
                retorno = "Cor escolhida inv�lida";

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
