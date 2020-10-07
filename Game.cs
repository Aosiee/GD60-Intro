//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Game
    {
        //! constants
        public const int MAP_SIZE = 10;

        //! local variables (private)
        private bool _gameOver = false;
        private Location _currentLocation = new Location("The Beginning", "You start here");
        private Player _player = new Player(MAP_SIZE);
        private Map _theGameMap = new Map(MAP_SIZE);
        
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
                    }
                
            }

        private void Update()
            {
                //collect user input
                _gameOver = handleAnswer(_gameOver);
                
                // update the _currentLocation here based on user input  

                //update player state
                _player.Update(/* ??? */);
                Console.WriteLine("You moved");

            }
        
        private void Render()
            {
                // use the _currentLocation to show the description
                Console.WriteLine(_theGameMap.ShowDescAt(_player.locX, _player.locY));

                //prompt the user for next action
                showActionPrompt();
                
            }

        private string showActionPrompt()
            {
            string[] promptList = new string[10];
            promptList[0] = "";
            promptList[1] = "";
            Console.WriteLine(promptList[0]);
            }

        bool didChange = false;
        private bool handleAnswer (bool gameState, bool didChange)
                    {
                        bool gameOver = gameState;
                        string answer = Console.ReadLine();
                        //int locationCompare;
                        //locationIndex
                        gameOver = false;
                        // ^ Necessary for error removal
                        switch(answer)
                        {
                            case "a":
                            {
                                Console.WriteLine("Option A");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            case "b":
                            {
                                Console.WriteLine("Option B");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            case "c":
                            {
                                Console.WriteLine("Option C");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }      

                            case "d":
                            {
                                Console.WriteLine("Option D");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            case "exit":
                            {
                                GameOverHandler();
                                break;
                            }

                            // This is so incase someone mis-types they can retry
                            default:
                            {
                                Console.WriteLine("Input Error. Please Try again");
                                Console.ReadKey();
                                Console.Clear();
                                gameOver = true;
                                break;
                            }
                        }
                        return didChange;
                    }
        //!Don't Know if this should stay here
        private void GameOverHandler()
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

        private void welcomePlayer()
        {
        Console.Title = "Text RPG!";
            //Console.SetWindowSize(100, 35);
            SetColour();
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
            }
    }
}