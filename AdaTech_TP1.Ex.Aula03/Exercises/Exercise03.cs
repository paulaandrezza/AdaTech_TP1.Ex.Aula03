namespace AdaTech_TP1.Ex.Aula03.Exercises
{
    internal class Exercise03 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Digite o número de jogadores: ");
                int numeroDeJogadores = int.Parse(Console.ReadLine());

                SimularJogoBatataQuente(numeroDeJogadores);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void SimularJogoBatataQuente(int numeroDeJogadores)
        {
            Queue<int> filaJogadores = new Queue<int>();

            for (int i = 1; i <= numeroDeJogadores; i++)
                filaJogadores.Enqueue(i);

            Random random = new Random();
            int passesAteExplodir = random.Next(1, 101);

            Console.WriteLine($"Número de passes até a batata explodir: {passesAteExplodir}");

            for (int i = 1; i < passesAteExplodir; i++)
            {
                ImprimirJogadores(filaJogadores);
                int jogadorAtual = filaJogadores.Dequeue();
                filaJogadores.Enqueue(jogadorAtual);
            }
            ImprimirJogadores(filaJogadores);

            int jogadorEliminado = filaJogadores.Dequeue();
            Console.WriteLine($"Jogador {jogadorEliminado} eliminado!");

        }

        static void ImprimirJogadores(Queue<int> jogadores)
        {
            Console.WriteLine(string.Join(", ", jogadores.Select(i => i.ToString())));
        }
    }
}