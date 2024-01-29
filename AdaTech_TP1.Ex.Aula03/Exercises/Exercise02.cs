namespace AdaTech_TP1.Ex.Aula03.Exercises
{
    internal class Exercise02 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Digite a expressão matemática: ");
                string expressao = Console.ReadLine();

                Console.WriteLine(VerificarBalanceamento(expressao) ? "Expressão balanceada" : "Expressão não balanceada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool VerificarBalanceamento(string expressao)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == '[' || caractere == '{')
                {
                    pilha.Push(caractere);
                }
                else if (caractere == ')' || caractere == ']' || caractere == '}')
                {
                    if (pilha.Count == 0)
                        return false;

                    char topoPilha = pilha.Pop();

                    if (!SaoPares(topoPilha, caractere))
                        return false;
                }
            }

            return pilha.Count == 0;
        }

        static bool SaoPares(char abertura, char fechamento)
        {
            return (abertura == '(' && fechamento == ')') ||
                   (abertura == '[' && fechamento == ']') ||
                   (abertura == '{' && fechamento == '}');
        }
    }
}
