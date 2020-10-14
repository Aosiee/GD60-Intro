//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Player
    {
        //private variables
        Random nRNG = new Random();
        Random mRNG = new Random();
        private string _name = "";
        private int _mapSize = 0;


        //public variables

        public int LocX = 2;
        public int LocY = 0;


        
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
        public Player ()
            {
                string name = "default_name";
                _mapSize = Options.MAP_SIZE;
                _name = name;
                locX = 2;
                locY = 0;
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

                //Exit Game
                if(playerSelection == "exit")
                    {
                        goto CantMoveEscape;;
                    }
                    CantMoveEscape:

                //Answers for Riddle.
                if(playerSelection == "one")
                    {
                        //If the player is in the riddle room.
                        if(_currentLocation.ItIsRiddle == true)
                            {
                                LocY = 6;
                                LocX = 2;
                            }  
                    }
                if(playerSelection == "1")
                    {
                        //If the player is in the riddle room.
                        if(_currentLocation.ItIsRiddle == true)
                            {
                                LocY = 6;
                                LocX = 2;
                            }  
                    }
                playerSelection = "default";

                //For Random Criteria
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
            }
    }
}