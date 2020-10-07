/* Copyright (C) 2020 Felipe Lara */
namespace adventure
{
    public class Map
    {
        
        //PROPERTIES
        private Location[,] _gameMap;
        private int _mapMaxSize = 10;

        //Constructor
        public Map(int mapSize)
            {
                if (mapSize < 1)
                return;

                _mapMaxSize = mapSize;
                _gameMap = new Location [mapSize,mapSize];
            }

        //Public Methods
        public void Init()
            {
                //Beach - Desc - 0
                _gameMap[0,0] = new Location("You awaken on a long white beach stretching farther than you can see. \n" +
                                            "A series of tall mountains loom over the beach, their shadows casting swathes of shadows. \n" + 
                                            "Wooden wreckage scattered along where the lapping waves had long receded. \n The remnants of a long mast. stands headfast offshore\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Check for washed-up goods\n" +
                                            "B) Investigate Mast\n" +
                                            "C) Investigate Mountains\n");
                _gameMap[0,0].SetAllowableDirections( true, true, true, true);

                //Shipwreck - Desc - 1
                _gameMap[0,1] = new Location("A crooked mast stands tirelessly against the brazen lapping waves. The remnants of what once \n" + 
                                            "must’ve been the starboard slightly peeking through the constant waves. \n" +
                                            "An odd eery feeling washes over you as you stare at the watery depths \n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Follow the Path\n" +
                                            "B) Run Straight into the Woods\n" +
                                            "C) Attempt to make your own path into the Mountain\n");

                //Mountain Path - Desc - 2
                _gameMap[0,2] = new Location("Away from the beach, a long and precarious path windes through a valley. \n" +
                                            "The faded remains of a once trafficked gravel road mark the beginnings of an ascent towards the tall peaks overcasting the beach.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Follow the Path\n" +
                                            "B) Run Straight into the Woods\n" +
                                            "C) Attempt to make your own path into the Mountain\n");
                _gameMap[0,2].SetAllowableDirections( true, true, true, true);

                //Cave Mouth - Desc - 3
                _gameMap[0,3] = new Location("The gaping mouth of a cave suddenly emerges as you come into a clearing. The jagged edges of the cave \n" +
                                            "leave the impression of an enraged animal\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Enter the Cave\n" +
                                            "B) Study the Jagged Rocks\n" +
                                            "C) Turn Back \n");
                _gameMap[0,3].SetAllowableDirections( true, true, true, true);

                //Tunnels - Desc - 4
                _gameMap[0,4] = new Location("Within the Cave, a long crooked tunnel acts as the throat of the sleeping beheamoth \n" +
                                            "the barest of sounds creeps forward from the tunnels\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Go Down the Tunnel\n" +
                                            "B) Attack Tunnel\n" +
                                            "C) Hug the Tunnel\n");
                _gameMap[0,4].SetAllowableDirections( true, true, true, true);

                //Tunnel - Forks - Desc - 5
                _gameMap[0,5] = new Location("The tunnel eventually splits, leaving two paths in front. One carries \n" +
                                            "the sounds of screams, the cave walls only work to amplify the sound. The other, \n" +
                                            "the quiet sounds of a people weeping.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Investigate the Screaming Tunnel\n" +
                                            "B) Investigate the Weeping Tunnel\n" +
                                            "C) Flee\n");
                _gameMap[0,5].SetAllowableDirections( true, true, true, true);

                //Tunnel - Screams - Desc - 6
                _gameMap[0,6] = new Location("As you go down the tunnel, the screams intesify. A large bustling town \n" +
                                            "of gnomes appears. Their cheers and bounce off the tunnel walls warping them \n" +
                                            "into horrifying sounds.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Go into Town\n" +
                                            "B) Avoid the Town\n" +
                                            "C) Turn Back\n");
                _gameMap[0,6].SetAllowableDirections( true, true, true, true);

                //Cave Town - Desc - 7
                _gameMap[0,7] = new Location("The town is bustling and lively, a large crowd stands in the centre of the town. A \n" +
                                            "grand spire stands in the rear of the town, menacing over the small quaint town.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Walk Around the Town\n" +
                                            "B) Investigate the Crowd\n" +
                                            "C) Head Towards the Tower\n");
                _gameMap[0,7].SetAllowableDirections( true, true, true, true);

                //Weeping Tunnel - Desc - 8
                _gameMap[0,8] = new Location("The tunnel opens into a vast cavern. An unerving darkness consumes all within. \n" +
                                            "Yet, dim shadows roam, their shapes moving with hast upon your arrival.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Attempt to Scare the Creatures\n" +
                                            "B) Weep with Them\n" +
                                            "C) Turn Back\n");
                _gameMap[0,8].SetAllowableDirections( true, true, true, true);


                //Dungeon - Desc - 9
                _gameMap[0,9] = new Location("As you approach the spire, the building's size dwarfs your own." +
                                            "A gargantuan gate blocks your entry, the words \"Dungeon\" hang precariously \n" +
                                            "above the massive wooden doors. A small window slides open on the bottom left \n" +
                                            "of the door. A dark figure lurks behind it.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Approach the Dark Figure\n" +
                                            "B) Charge at the Door\n" +
                                            "C) Attempt to Jump through the Window\n");
                _gameMap[0,9].SetAllowableDirections( true, true, true, true);
            }

        public Location LocationAt( int i, int j)
            {
                if((i < _mapMaxSize) || (j < _mapMaxSize))
                return new Location("The Abyss - you died");
                return _gameMap[i,j];
            }
        public string DescAt (int i, int j)
            {
                Location loc = LocationAt(i, j);
                return loc.Desc();

            }

        public string ShowDescAt (int locX, int locY)
        {
                        return DescAt(locX, locY);
        }
        

    }
}