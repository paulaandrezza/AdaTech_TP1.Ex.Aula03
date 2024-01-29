namespace AdaTech_TP1.Ex.Aula03.UI
{
    internal class Menu
    {
        private readonly string[] items;
        private int selectedIndex;

        public Menu(string[] menuItems)
        {
            items = menuItems;
            selectedIndex = 0;
        }

        public int ShowMenu(string? title = null)
        {
            ConsoleKeyInfo key;
            Console.CursorVisible = false;

            try
            {
                do
                {
                    Console.Clear();
                    RenderMenu(title);

                    key = Console.ReadKey(true);

                    HandleKeyPress(key);

                } while (key.Key != ConsoleKey.Enter);
            }
            finally
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.CursorVisible = true;
            }

            Console.WriteLine($"\nOpção selecionada: {items[selectedIndex]}\n");
            return selectedIndex;
        }

        private void RenderMenu(string? title = null)
        {
            if (title != null)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("\nSelecione uma opção: \n");

            for (int i = 0; i < items.Length; i++)
            {
                Console.ForegroundColor = (i == selectedIndex) ? ConsoleColor.Black : ConsoleColor.Gray;
                Console.BackgroundColor = (i == selectedIndex) ? ConsoleColor.Gray : ConsoleColor.Black;

                Console.WriteLine($"{items[i]}");

                Console.ResetColor();
            }

            Console.WriteLine("\nAperte enter para confirmar.");
        }

        private void HandleKeyPress(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = Math.Max(0, selectedIndex - 1);
                    break;

                case ConsoleKey.DownArrow:
                    selectedIndex = Math.Min(items.Length - 1, selectedIndex + 1);
                    break;
            }
        }
        public static void WaitInput()
        {
            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int DisplayMenu(string[] options, string? title = null)
        {
            int selected;
            Menu menu = new Menu(options);

            while (true)
            {
                Console.Clear();
                selected = menu.ShowMenu(title);
                if (selected >= 0 && selected <= options.Length)
                    break;
            }

            return selected;
        }

        public static string[] GenerateOptions(int lengthItems, string[] label)
        {
            string[] options = new string[lengthItems + 1];
            for (int i = 0; i < lengthItems; i++)
                options[i] = $"Exercicio {i + 1:00} - {label[i]}";

            options[lengthItems] = "Sair";

            return options;
        }
    }
}
