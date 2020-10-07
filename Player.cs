using System;

namespace adventure
{
    public class Player
    {
    public int[]_playerLocation = new int[2];

    //Constructor
    public void playerStatus()
        {
            InitialPlayer();
        }

    public void InitialPlayer()
        {
            _playerLocation[1] = 0;
            _playerLocation[0] = 0;
        }

    public bool UpdatePlayerLocation(string action)
        {
            bool didChange = false;

            //get currect action
            switch(action)
                {
                    case "a":
                        {
                            _playerLocation[1]++;
                            didChange = true;
                            break;
                        }
                    case "b":
                        {
                            _playerLocation[0]++;
                            didChange = true;
                            break;
                        }
                    case "c":
                        {
                            _playerLocation[1]--;
                            didChange = true;
                            break;
                        }
                    case "d":
                        {    
                            _playerLocation[0]--;
                            didChange = true;
                            break;
                        }
                }
                return didChange;
        }

    }
}