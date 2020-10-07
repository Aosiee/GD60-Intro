//Copyright (C) 2020 Felipe Lara

using System;

namespace adventure
{
    public class Style
    {
        //CONSTRUCTOR

        //public style

        public void GameOverHandler()
            {
            Console.Clear();
            SetColour();
                Console.WriteLine("-=Game Over=- \n Thank you for playing!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(1);
            }

        //!Don't Know if this should stay here
        public void SetColour()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }

    }
}