/* Copyright (C) 2020 Felipe Lara */

using System;

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
                // UP, DOWN, LEFT, RIGHT
                //Beach - Desc - 0
                _gameMap[2,0] = new Location("You awaken on a long white beach stretching farther than you can see. \n" +
                                            "A series of tall mountains loom over the beach, their shadows casting swathes of shadows. \n" + 
                                            "Wooden wreckage scattered along where the lapping waves had long receded. \n The remnants of a long mast. stands headfast offshore\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Investigate Mountains\n" +
                                            "C) Check for washed-up goods\n");
                _gameMap[2,0].SetAllowableDirections(true, false, true, false);

                //Shipwreck - Desc - 1
                _gameMap[1,0] = new Location("A crooked mast stands tirelessly against the brazen lapping waves. The remnants of what once \n" + 
                                            "must’ve been the starboard slightly peeking through the constant waves. \n" +
                                            "An odd eery feeling washes over you as you stare at the watery depths \n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Run Straight into the Woods\n" +
                                            "B) Return to Beach\n" +
                                            "C) Investigate Mast\n");
                _gameMap[1,0].SetAllowableDirections( true, false, true, true);

                //Shipwreck - Desc - 1.5 - Kracken //!DEATH
                _gameMap[0,0] = new Location("As you swim out to the wreckage, a massive Kracken appears!\n" + 
                                            "He instantly gobbles you up\n" +
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "You Died, Please \"Exit\"\n");
                _gameMap[0,0].SetAllowableDirections( false, false, false, false);

                //Mountain Path - Desc - 2
                _gameMap[2,1] = new Location("Away from the beach, a long and precarious path windes through a valley. \n" +
                                            "The faded remains of a once trafficked gravel road mark the beginnings of an ascent towards the tall peaks overcasting the beach.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Follow the Path\n" +
                                            "B) Attempt to make your own path into the Mountain\n");
                _gameMap[2,1].SetAllowableDirections( true, false, false, true);

                //Run Straight into the Woods - Desc -
                _gameMap[1,2] = new Location("As you run into the woods, you get lost. The trees confuse you and they appear to be moving.\n" +
                                            "Their branches are beginning to loom towards you.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "RANDOM) Attempt to make your own path back to the mountain road\n" +
                                            "C) Wait for their cuddly hugs :)\n");
                _gameMap[1,2].SetAllowableDirections( false, false, true, true);

                //TODO:RANDOM THE RETURN

                //Death - Desc - //!DEATH
                _gameMap[0,2] = new Location("Their hugs are painful... very painful. \n" +
                                            "You die, Please \"Exit\"\n \n");
                _gameMap[0,2].SetAllowableDirections( false, false, false, false);

                _gameMap[0,1] = new Location("Their hugs are painful... very painful. \n" +
                                            "You die, Please \"Exit\"\n \n");
                _gameMap[0,1].SetAllowableDirections( false, false, false, false);

                //Make Way Up to Obelisks - Desc -
                _gameMap[3,1] = new Location("You make your way up the mountain. \n" +
                                            "You come across a clearing...\n" +
                                            "-=Choices=- \n \n" +
                                            "B) Walk up to the clearing\n");
                _gameMap[3,1].SetAllowableDirections( false, false, false, true);

                //Obelisks of Death - //!DEATH -
                _gameMap[4,1] = new Location("You see several tall obelisks oozing with energy. \n" +
                                            "an uncontrollable urge to touch them comes across you... \n \n" + 
                                            "You die, Please \"Exit\"\n \n");
                _gameMap[4,1].SetAllowableDirections( false, false, false, true);

                //Follow Path to Cave - Desc - 3
                _gameMap[2,2] = new Location("The gaping mouth of a cave suddenly emerges as you come into a clearing. The jagged edges of the cave \n" +
                                            "leave the impression of an enraged animal\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Go To Cave\n");
                _gameMap[2,2].SetAllowableDirections( true, false, false, false);


                            // UP, DOWN, LEFT, RIGHT
                //Tunnels - Desc - 4
                _gameMap[2,3] = new Location("Within the Cave, a long crooked tunnel acts as the throat of the sleeping beheamoth \n" +
                                            "the barest of sounds creeps forward from the tunnels\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Go Down the Tunnel\n" +
                                            "B) Hug the Tunnel\n" +
                                            "C) Attack Tunnel\n");
                _gameMap[2,3].SetAllowableDirections( true, false, true, true);

                _gameMap[1,3] = new Location("You attack the cave's walls. You hear a low growl... \n" +
                                            "You die, Please \"Exit\"\n \n");
                _gameMap[1,3].SetAllowableDirections( false, false, false, false);

                _gameMap[3,3] = new Location("You hug the a Cave. The cave likes you. You hear a loud purr begin. \n" +
                                            "the barest of sounds creeps forward from the tunnels\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "You die, Please \"Exit\"\n \n");
                _gameMap[3,3].SetAllowableDirections( false, false, false, false);

                //Tunnel - Forks - Desc - 5
                _gameMap[2,4] = new Location("The tunnel eventually splits, leaving two paths in front. One carries \n" +
                                            "the sounds of screams, the cave walls only work to amplify the sound. The other, \n" +
                                            "the quiet sounds of a people weeping.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "A) Investigate the Screaming Tunnel\n" +
                                            "B) Investigate the Weeping Tunnel\n" +
                                            "C) Flee\n");
                _gameMap[2,4].SetAllowableDirections( true, false, true, true);

                _gameMap[1,4] = new Location("You try to flee only to find that the way back has been blockaded by \n" +
                                            "a thick stone wall \n \n" + 
                                            "-=Choices=- \n \n" +
                                            "B) Return to Previous Choices\n");
                _gameMap[1,4].SetAllowableDirections( false, false, false, true);

                _gameMap[3,4] = new Location("You go to investigate the Weeping tunnels.\n \n" + 
                                            "-=Choices=- \n \n" +
                                            "What Will You Do?\n" +
                                            "B) Further Investigate the Weeping Tunnel\n" +
                                            "C) Turn Back\n");
                _gameMap[3,4].SetAllowableDirections( false, false, true, true);

                //Tunnel - Screams - Desc - 6
                _gameMap[2,5] = new Location("As you go down the tunnel, the screams intesify. A large bustling town \n" +
                                            "of gnomes appears. Their cheers and bounce off the tunnel walls warping them \n" +
                                            "into horrifying sounds. Yet as you approach them, their shapes warp \n" +
                                            "into that of people you know. As you look upon their faces, you wake up.\n" +
                                            "Congratulations you Survived! You are kool" +
                                            "You Win, Please Type \"Exit\" \n \n");
                _gameMap[2,5].SetAllowableDirections( false, false, false, false);
                                // UP, DOWN, LEFT, RIGHT
                //Weeping Tunnel - Desc - 8
                _gameMap[4,4] = new Location("The tunnel opens into a vast cavern. An unerving darkness consumes all within. \n" +
                                            "Yet, dim shadows roam, their shapes moving with hast upon your arrival. They claw you to death\n \n" + 
                                            "You die, Please \"Exit\"\n \n");
                _gameMap[4,4].SetAllowableDirections( false, false, false, false);
            }

        public Location LocationAt (int i, int j)
            {
                if((i < _mapMaxSize) || (j < _mapMaxSize))
                    {
                    return (_gameMap[i,j]);
                    }

                else
                    {
                    return LocationAt(i,j);
                    }

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