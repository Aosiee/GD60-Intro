//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Player
    {
        public const int MAX_ITEMS = 10;

        //private variables
        private string _name = "";

        //!Player stats
        //!REMOVED

        //private Item[] _inventory;

        private int _mapSize = 0;

        //public variables

        public int positionX = 0;
        public int positionY = 0;

        public string playerSelection = "blank";
        //FIXME: STACK OVERFLOW ERROR
        public int locX{get; set;}
            /*
            {
                get
                    {
                        return locX;
                    }
                set
                    {
                        if (value < 0)
                            {
                                locX = 0;
                                return;
                            }
                        if (value > _mapSize)
                            {
                                locX = _mapSize;
                                return;
                            }
                    }
            }
            */
        public int locY{get; set;}
            /*
            {
                get
                    {
                        return locY;
                    }
                set
                    {
                        if (value < 0)
                            locY = 0;
                        if (value > _mapSize)
                            locY = _mapSize;    
                    }
            }
            */
        public Player ( int mapSize, string name = "Redshirt guy")
            {
                _mapSize = mapSize;
                _name = name;
                locX = 0;
                locY = 0;
                locX = positionX;
                locY = positionY;

                //_inventory = new Item[MAX_ITEMS];
            }

        public void Update(ref string playerSelection)
            {
                if(playerSelection == "a")
                    {
                        locY++;
                    }
                if(playerSelection == "b")
                    {
                        locX++;
                    }
                if(playerSelection == "c")
                    {
                        locX--;
                    }
                if(playerSelection == "d")
                    {
                        locY--;
                    }
                //update the player's location
            }
        public bool handleAnswer (bool gameState, bool didChange, out string playerSelection)
                    {
                        bool gameOver = gameState;
                        playerSelection = Console.ReadLine().ToLower();
                        //int locationCompare;
                        //locationIndex
                        gameOver = false;
                        // ^ Necessary for error removal
                        switch(playerSelection)
                        {
                            case "a":
                            {
                                Console.WriteLine("Option A - Y++");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            case "b":
                            {
                                Console.WriteLine("Option B - X++");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            case "c":
                            {
                                Console.WriteLine("Option C - X--");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }      

                            case "d":
                            {
                                Console.WriteLine("Option D - Y--");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            case "exit":
                            {
                                //TODO: fix this -> GameOverHandler();
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
    }
}