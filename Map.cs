/* Copyright (C) 2020 Felipe Lara */
namespace adventure
{
    public class Map
    {
        
        private Location[,] _gameMap;

        public Map(int mapSize)
            {
                _gameMap = new Location [mapSize,mapSize];
            }



    }
}