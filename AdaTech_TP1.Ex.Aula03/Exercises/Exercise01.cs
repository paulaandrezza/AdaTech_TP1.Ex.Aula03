namespace AdaTech_TP1.Ex.Aula03.Exercises
{
    internal class Exercise01 : Exercise
    {
        public override void Execute()
        {
            try
            {
                var input = new List<string>
                {
                    "Idiossincrasia",
                    "Ambivalente",
                    "Quimérica",
                    "Perpendicular",
                    "Efêmero",
                    "Pletora",
                    "Obnubilado",
                    "Xilografia",
                    "Quixote",
                    "Inefável"
                };

                List<string> result = FiltrarStringsPorTamanho(input, 10);

                Console.WriteLine("Strings com 10 ou mais caracteres:");
                foreach (var str in result)
                {
                    Console.WriteLine(str);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static List<string> FiltrarStringsPorTamanho(List<string> lista, int tamanhoMinimo)
        {
            List<string> result = new List<string>();

            foreach (var str in lista)
            {
                if (ObterComprimento(str) >= tamanhoMinimo)
                    result.Add(str);
            }

            return result;
        }
        static int ObterComprimento(string str)
        {
            int comprimento = 0;
            foreach (char c in str)
            {
                if (c == '\0')
                    break;

                comprimento++;
            }

            return comprimento;
        }
    }
}
