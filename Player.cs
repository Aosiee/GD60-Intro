//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Player
    {
        //private variables
        private string _name = "";
        private int _mapSize = 0;

        //public variables
        public int locX
            {
                get
                    {
                        return locX;
                    }
                set
                    {
                        if (value < 0)
                            locX = 0;
                        if (value > _mapSize)
                            locX = _mapSize;
                    }
            }
        public int locY
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

        public Player ( int mapSize, string name = "Redshirt guy")
            {
                _mapSize = mapSize;
                _name = name;
                locX = 0;
                locY = 0;
            }

        public void Update()
            {
                //update the player's location
            }
    }
}