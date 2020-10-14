//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Game
    {
        

        //! local variables (private)
        public bool _gameOver = false;
        private Location _currentLocation = new Location("default_desc");
        private Player _player = new Player();
        private Map _theGameMap = new Map();
        private MovementHandler _handlemove = new MovementHandler(true);
        private Style _style = new Style();
        //private Options options = new Options();
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
                
                //There are two CheckEndGame to prevent double exits & prevent glitches displaying on screen when ending game
                Render();
                while(!_gameOver)
                    {
                        CheckEndGame();
                        Update();
                        CheckEndGame();
                        Render();
                    }
                
            }

        private void Update()
            {
                //collect user input
                MovementHandler.handleAnswer(didChange, out _handlemove.playerSelection, out testGameOver);

                // update the _currentLocation here based on user input  

                //update player state
                _player.Update(ref _handlemove.playerSelection, _currentLocation);
                //Console.WriteLine("You moved");

            }
        private void Render()
            {
                _style.SetColour();
                Console.WriteLine("-=+ Story +=-");
                Console.ResetColor();

                // use the _currentLocation to show the description and prompt
                _currentLocation = _theGameMap.LocationAt(_player.locX, _player.locY);
                Console.WriteLine(_currentLocation._description);

                //!DEBUG LOCATION
                if(Options.DEBUG_MODE == true)
                    {
                        Console.WriteLine("\n-=DEBUG=-");
                        Console.WriteLine($"{_player.locX} = X");
                        Console.WriteLine($"{_player.locY} = Y");
                    }
            }

        private void CheckEndGame()
            {
                _handlemove.endGame = testGameOver;
                if(testGameOver == true)
                    {
                        _gameOver = true;
                    }
            }
        
        private void welcomePlayer()
            {
            Console.Title = "Text RPG!";
            //Console.SetWindowSize(100, 35);
            _style.SetColour();
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
            Console.Clear();
            }
    }
}