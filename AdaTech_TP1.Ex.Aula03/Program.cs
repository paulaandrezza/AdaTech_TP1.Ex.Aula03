﻿using AdaTech_TP1.Ex.Aula03.Exercises;
using AdaTech_TP1.Ex.Aula03.UI;

namespace AdaTech_TP1.Ex.Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise[] exercises =
            [
                new Exercise01(),
                new Exercise02(),
                new Exercise03(),
                new Exercise04(),
            ];
            while (true)
            {
                var options = Menu.GenerateOptions(exercises.Length);
                int option = Menu.DisplayMenu(options, Title.TitleExercises());
                if (option == exercises.Length)
                    break;
                exercises[option].Execute();
                Menu.WaitInput();
            }
        }
    }
}
