//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    //! constants
    public class Options
        {
        public const int MAP_SIZE = 10;
        public const bool DEBUG_MODE = true;
        }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }
}