namespace AULA02.Models
{
    public class DataType
    {
        public char myVar = 'a';
        public char myConst = 'b';

        public char myChar1 = 'f';
        public char myChar2 = ':';
        public char myChar3 = 'x';

        //Podemos também atribuir referência
        //de caracteres unicode

        public char myChar4 = '\u2726';

        //Podemos ainda mesclar caracteres especiais
        //como, nova linha, tabulação e etc.
        public string TextLine = "Esta é uma linha de texto.\n\n\nE esta é outra linha.";

        /* 
        \e - Caracter de escape
        \n - Nova linha
        \r - Retorno
        \t - Tabulação horizontal
        \" - Aspas duplas, usadas para exibir aspas debtro da string
        \' - Aspas simples, usada para exibir ' dentro da string
        *

        /*
        Interpolação de strings
        Combinando strings de diferentes maneiros no C#
         */

        private int count = 10;
        public string message;

        public DataType()
        {
            message = $"O contador está em {count}.";

            string username = "Ryan";
            int inboxCount = 100;
            int maxCount = 100;

            message += $"\nO usuário {username} tem {inboxCount} mensagens.";
            message += $"\nEspaço restante em sua caixa {maxCount - inboxCount}";
        }

        
    }
}
