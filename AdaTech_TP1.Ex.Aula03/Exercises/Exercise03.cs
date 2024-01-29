namespace AdaTech_TP1.Ex.Aula03.Exercises
{
    internal class Exercise03 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Digite o número de jogadores: ");
                int numberOfPlayers = int.Parse(Console.ReadLine());

                SimulateGameHotPotato(numberOfPlayers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void SimulateGameHotPotato(int numberOfPlayers)
        {
            Queue<int> queuePlayers = new Queue<int>();

            for (int i = 1; i <= numberOfPlayers; i++)
                queuePlayers.Enqueue(i);

            Random random = new Random();
            int passesUntilExplode = random.Next(1, 101);

            Console.WriteLine($"Número de passes até a batata explodir: {passesUntilExplode}");

            for (int i = 1; i < passesUntilExplode; i++)
            {
                PrintPlayers(queuePlayers);
                int currentPlayer = queuePlayers.Dequeue();
                queuePlayers.Enqueue(currentPlayer);
            }
            PrintPlayers(queuePlayers);

            int playerEliminated = queuePlayers.Dequeue();
            Console.WriteLine($"Jogador {playerEliminated} eliminado!");

        }

        static void PrintPlayers(Queue<int> players)
        {
            Console.WriteLine(string.Join(", ", players.Select(i => i.ToString())));
        }
    }
}