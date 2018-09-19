using System;
using System.Runtime.InteropServices;

namespace Project_Arcade
{
    public class GameChooser
    {
        
        private static string[] Arcade =
        {
            "    ___                        __   ", "   /   |  ______________ _____/ /__ ",
            "  / /| | / ___/ ___/ __ `/ __  / _ \\", " / ___ |/ /  / /__/ /_/ / /_/ /  __/",
            "/_/  |_/_/   \\___/\\__,_/\\__,_/\\___/ "
        };

        public static void ShowText()
        {
            foreach (string line in Arcade)
            {
                Console.WriteLine(line);
            }
        }

        public static void Select()
        {
            Console.WriteLine("\r\n");
            Console.WriteLine("Press [1] to Play");
            var check = Console.ReadLine();

            switch (check)
            {
                case "1":
                    Console.Clear();
                    ShowText();
                    Menu2();
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
        }

        public static void Menu2()
        {
            Console.WriteLine("\r\n");
            Console.WriteLine("Select a Game");
            Console.WriteLine("Press [1] to play Snake");
            Console.WriteLine("Press [2] to play Hangman");


            var check = Console.ReadLine();

            switch (check)
            {
                case "1":
                    Console.WriteLine("Snake");
                    break;
                case "2":
                    Console.WriteLine("Hangman");
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
        }
    }
}