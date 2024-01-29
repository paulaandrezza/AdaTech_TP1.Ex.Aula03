using System.Text.RegularExpressions;

namespace AdaTech_TP1.Ex.Aula03.Exercises
{
    internal class Exercise04 : Exercise
    {
        public override void Execute()
        {
            try
            {
                Console.WriteLine("Digite um texto:");
                string text = Console.ReadLine();

                text = NormalizeText(text);
                string[] words = ExtractWords(text);
                Dictionary<string, int> wordCount = CountWords(words);

                DisplayWordFrequency(wordCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string NormalizeText(string text)
        {
            return Regex.Replace(text.ToLower(), @"[^a-z\s]", " ");
        }

        private string[] ExtractWords(string text)
        {
            return Regex.Split(text.Trim(), @"\s+|\t+");
        }

        private Dictionary<string, int> CountWords(string[] words)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            return wordCount;
        }

        private void DisplayWordFrequency(Dictionary<string, int> wordCount)
        {
            Console.WriteLine("\nFrequência das Palavras:");
            foreach (var item in wordCount)
                Console.WriteLine($"{item.Key}: {item.Value} vez{(item.Value > 1 ? "es" : "")}");
        }
    }
}
