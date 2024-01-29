namespace AdaTech_TP1.Ex.Aula03.Exercises
{
    internal class Exercise02 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Digite a expressão matemática: ");
                string expression = Console.ReadLine();

                Console.WriteLine(CheckBalancing(expression) ? "Expressão balanceada" : "Expressão não balanceada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool CheckBalancing(string expression)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char character in expression)
            {
                if (character == '(' || character == '[' || character == '{')
                {
                    pilha.Push(character);
                }
                else if (character == ')' || character == ']' || character == '}')
                {
                    if (pilha.Count == 0)
                        return false;

                    char topoPilha = pilha.Pop();

                    if (!SameType(topoPilha, character))
                        return false;
                }
            }

            return pilha.Count == 0;
        }

        static bool SameType(char opening, char closure)
        {
            return (opening == '(' && closure == ')') ||
                   (opening == '[' && closure == ']') ||
                   (opening == '{' && closure == '}');
        }
    }
}
