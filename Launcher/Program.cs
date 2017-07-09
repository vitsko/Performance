﻿namespace Launcher
{
    using System;
    using Calculate;
    using Text;
    using static System.Console;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Title = Text.TitleConsole;
            bool exit = false;

            while (!exit)
            {
                Screen.ShowMainMenu(Text.MainMenu);
                var selectCreateditem = Console.ReadKey().Key;

                switch (selectCreateditem)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Screen.ShowResultCompare(new CalculateArrayList(), new CalculateLinkedList());
                            break;
                        }

                    case ConsoleKey.Q:
                        exit = true;
                        break;
                }

                if (Screen.IsSelectedMenu(selectCreateditem))
                {
                    ReadKey();
                }
            }
        }
    }
}