//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Player
    {
        public const int MAX_ITEMS = 10;

        //private variables
        private string _name = "";

        //!FIXME: Player stats
        //!REMOVED

        private int _mapSize = 0;

        //public variables

        public int positionX = 0;
        public int positionY = 0;

        
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
        public Player ( int mapSize, string name = "default_name")
            {
                _mapSize = mapSize;
                _name = name;
                locX = 0;
                locY = 0;
                locX = positionX;
                locY = positionY;

                //_inventory = new Item[MAX_ITEMS];
            }

        public void Update(string playerSelection)
        //Recieves from MovementHandler, moves player
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
            }
    }
}