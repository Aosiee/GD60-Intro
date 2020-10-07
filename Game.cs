//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Game
    {
        //! constants
        public const int MAP_SIZE = 10;
        public const bool DEBUG_MODE = true;

        //! local variables (private)
        public bool _gameOver = false;
        private Location _currentLocation = new Location("default_desc");
        private Player _player = new Player(MAP_SIZE);
        private Map _theGameMap = new Map(MAP_SIZE);
        private MovementHandler _handlemove = new MovementHandler(true);
        //private Style _style = new Style(true);
        private bool didChange = false;
        private bool testGameOver = false; 

        //!Constructor
        public Game()
            {
                //Create map
                _theGameMap.Init();

                //Load Locations, location data

                //setup game
            }

        public void Run()
            {
                welcomePlayer();
                Render();
                while(!_gameOver)
                    {
                        Update();
                        Render();
                        CheckEndGame();
                    }
                
            }

        private void Update()
            {
                //collect user input
                MovementHandler.handleAnswer(_gameOver, didChange, out _handlemove.playerSelection);
                
                // update the _currentLocation here based on user input  

                //update player state
                _player.Update(_handlemove.playerSelection);
                //Console.WriteLine("You moved");

            }
        private void Render()
            {
                // use the _currentLocation to show the description and prompt
                Console.WriteLine(_theGameMap.ShowDescAt(_player.locX, _player.locY));
                //!DEBUG LOCATION
                if(DEBUG_MODE == true)
                    {
                        Console.WriteLine("\n-=DEBUG=-");
                        Console.WriteLine($"{_player.locX} = X");
                        Console.WriteLine($"{_player.locY} = Y");
                    }
            }

        private void CheckEndGame()
            {
                if(testGameOver == true)
                    {
                        _gameOver = true;
                    }
            }
        
        private void welcomePlayer()
            {
            Console.Title = "Text RPG!";
            //Console.SetWindowSize(100, 35);
            //SetColour();
            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");    
            Console.WriteLine("█                   ╦─╦ ╔╗ ╦  ╔╗ ╔╗ ╔╦╗ ╔╗ ╔╗                    █");    
            Console.WriteLine("█                   ║║║ ╠─ ║  ║─ ║║ ║║║ ╠─ ╚╝                    █");    
            Console.WriteLine("█                   ╚╩╝ ╚╝ ╚╝ ╚╝ ╚╝ ╩─╩ ╚╝ ╚╝                    █");    
            Console.WriteLine("█                     -The Forgotten Cove-                       █");
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.WriteLine("█                        A Text-based RPG                        █");                
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");    
            Console.ResetColor();
            Console.WriteLine("Hello, Adventurer!\nYour Adventure Shall Begin!\n-=Press Any Key=-");
            Console.ReadLine();
            }
    }
}