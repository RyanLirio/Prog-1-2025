using Microsoft.AspNetCore.Mvc;

namespace AULA03.Views.JogoVelha
{
    public class JogoVelhaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(
            string A00, string A01, string A02,
            string A10, string A11, string A12,
            string A20, string A21, string A22
        )
        {
            string[,] matrixJV = new string[3, 3];
            matrixJV[0, 0] = A00;
            matrixJV[0, 1] = A01;
            matrixJV[0, 2] = A02;

            matrixJV[1, 0] = A10;
            matrixJV[1, 1] = A11;
            matrixJV[1, 2] = A12;

            matrixJV[2, 0] = A20;
            matrixJV[2, 1] = A21; 
            matrixJV[2, 2] = A22;
            string aij = string.Empty;
            string retorno = string.Empty;


            for(int j = 0; j < matrixJV.GetLength(0); j++)
            {
                if (!string.IsNullOrEmpty(matrixJV[j, 0]) && matrixJV[j, 0] == matrixJV[j, 1] && matrixJV[j, 1] == matrixJV[j, 2])
                {
                    retorno = "Ganhou pia, você ganhou com uma linha horizontal!";
                    break;
                }
                else
                {
                    for(int i = 0; i < matrixJV.GetLength(1); i++)
                    {
                        if(matrixJV[0, i] == matrixJV[1, i] && matrixJV[1, i] == matrixJV[2, i])
                        {
                            retorno = "Ganhou pia, você ganhou com uma linha vertical!";
                        }
                        else
                        {
                            for(int d1 = 0; d1 < matrixJV.Length; d1++)
                            {

                                if (matrixJV[0, 0] == matrixJV[1, 1] & matrixJV[1, 1] == matrixJV[2, 2])
                                {
                                    retorno = "Ganhou pia, você ganhou com uma linha diagonal!";
                                    break;
                                }
                                else if (matrixJV[2, 0] == matrixJV[1, 1] & matrixJV[1, 1] == matrixJV[0, 2])
                                {
                                    retorno = "Ganhou pia, você ganhou com uma linha diagonal!";
                                    break;
                                }
                                else
                                {
                                    retorno = "Deu velha!";
                                }
                            }
                            break;

                        }
                    }
                    break;
                }
            }
            Console.WriteLine(retorno);
            return View("Index", retorno);
        }
    }
}
