//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Player
    {
        public const int MAX_ITEMS = 10;

        //private variables
        private int LocX = 2;
        private int LocY = 0;
        private string _name = "";

        //!FIXME: Player stats
        //!REMOVED

        private int _mapSize = 0;

        Random nRNG = new Random();
        Random mRNG = new Random();

        //public variables

        public int positionX = 0;
        public int positionY = 0;

        
        //FIXME: STACK OVERFLOW ERROR
        public int locX
            {
                get
                    {
                        return LocX;
                    }
                set
                    {
                         if (value < 0)
                            {
                                LocX = 0;
                                return;
                            }
                        if (value > _mapSize)
                            {
                                LocX = _mapSize;
                                return;
                            } 
                    }
            }
            
        public int locY
            {
                get
                    {
                        return LocY;
                    }
                set
                    {
                        if (value < 0)
                            LocY = 0;
                        if (value > _mapSize)
                            LocY = _mapSize;    
                    }
            }
        public Player ( int mapSize, string name = "default_name")
            {
                _mapSize = mapSize;
                _name = name;
                locX = 2;
                locY = 0;
                locX = positionX;
                locY = positionY;

                //_inventory = new Item[MAX_ITEMS];
            }

        public void Update(ref string playerSelection, Location _currentLocation)
        //Recieves from MovementHandler, moves player
            { 
                if(playerSelection == "a")
                    {
                        if(!_currentLocation.CanGoUp)
                            {
                                playerSelection = "errored";
                                goto CantMoveEscape;
                            }
                        LocY++;
                    }
                if(playerSelection == "b")
                    {
                        if(!_currentLocation.CanGoRight)
                            {
                                playerSelection = "errored";
                                goto CantMoveEscape;
                            }
                        LocX++;
                    }
                if(playerSelection == "c")
                    {
                        if(!_currentLocation.CanGoLeft)
                            {
                                playerSelection = "errored";
                                goto CantMoveEscape;
                            }
                        LocX--;
                    }
                if(playerSelection == "d")
                    {
                        if(!_currentLocation.CanGoDown)
                            {
                                playerSelection = "errored";
                                goto CantMoveEscape;
                            }
                        LocY--;
                    }
                if(playerSelection == "random")
                    {
                            //More true random than if only one
                            int randomNumberOne = nRNG.Next(1,10);
                            int randomNumberTwo = mRNG.Next(1,10);
                            int trueRandomNumber = randomNumberOne * randomNumberTwo;
                            
                            if (trueRandomNumber > 50)
                                {
                                    LocX++;
                                }
                            else
                                {
                                    LocY--;
                                }
                    }
                if(playerSelection == "exit")
                    {
                        goto CantMoveEscape;;
                    }
                    CantMoveEscape:
                playerSelection = "default";
            }
    }
}