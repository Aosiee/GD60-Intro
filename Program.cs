//Copyright (C) 2020 Felipe Lara, All Rights Reserved

using System;

namespace adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcomes the Player to the game
            WelcomePlayer();
            Console.ReadKey();
            Console.Clear();

            bool gameOver = false;
            int locationIndex = 0;
            while(!gameOver)
            {
                for( locationIndex = 0; locationIndex < locationList.Length || !gameOver; locationIndex++)
                {
                    //!Displays the location & makes it pretty
                    SetColour();
                    Console.WriteLine("-=Story=-");
                    Console.ResetColor();
                    Console.WriteLine(locationList[locationIndex]);

                    //!Displays the prompt & recieves answer & makes it pretty as well :)
                    SetColour();
                    Console.WriteLine("-=Choices=-");
                    Console.ResetColor();
                    Console.WriteLine(promptList[locationIndex]);
                    string playerSelection = Console.ReadLine().ToLower();

                    //Handles the Options that the player can select
                    AnswerHandler(playerSelection, ref locationIndex, out gameOver);

                    // This makes sure that the program doesn't go over the Array as said in README.txt
                    if(locationIndex == 9) { gameOver = true; goto Endgame; }
                    else if (locationIndex == 10) { gameOver = true; goto Endgame; }

                    }
            }
            // Handles Game Over Situations
            Endgame: GameOverHandler();   
        }

       //!Arrays Location & Prompt
        static string[] locationList = new string[]

        //!Locatiom Array
        {
            //Beach - Desc - 0
            "You awaken on a long white beach stretching farther than you can see. \n" +
            "A series of tall mountains loom over the beach, their shadows casting swathes of shadows. \n" + 
            "Wooden wreckage scattered along where the lapping waves had long receded. \n The remnants of a long mast. stands headfast offshore",

            //Shipwreck - Desc - 1
            "A crooked mast stands tirelessly against the brazen lapping waves. The remnants of what once \n" + 
            "must’ve been the starboard slightly peeking through the constant waves. \n" +
            "An odd eery feeling washes over you as you stare at the watery depths ",

            //Mountain Path - Desc - 2
            "Away from the beach, a long and precarious path windes through a valley. \n" +
            "The faded remains of a once trafficked gravel road mark the beginnings of an ascent towards the tall peaks overcasting the beach.",

            //Cave Mouth - Desc - 3
            "The gaping mouth of a cave suddenly emerges as you come into a clearing. The jagged edges of the cave \n" +
            "leave the impression of an enraged animal",

            //Tunnels - Desc - 4
            "Within the Cave, a long crooked tunnel acts as the throat of the sleeping beheamoth \n" +
            "the barest of sounds creeps forward from the tunnels",

            //Tunnel - Forks - Desc - 5
            "The tunnel eventually splits, leaving two paths in front. One carries \n" +
            "the sounds of screams, the cave walls only work to amplify the sound. The other, \n" +
            "the quiet sounds of a people weeping.",

            //Tunnel - Screams - Desc - 6
            "As you go down the tunnel, the screams intesify. A large bustling town \n" +
            "of gnomes appears. Their cheers and bounce off the tunnel walls warping them \n" +
            "into horrifying sounds.",

            //Cave Town - Desc - 7
            "The town is bustling and lively, a large crowd stands in the centre of the town. A \n" +
            "grand spire stands in the rear of the town, menacing over the small quaint town.",
            
            //Weeping Tunnel - Desc - 8
            "The tunnel opens into a vast cavern. An unerving darkness consumes all within. \n" +
            "Yet, dim shadows roam, their shapes moving with hast upon your arrival.",

            //Dungeon - Desc - 9
            "As you approach the spire, the building's size dwarfs your own." +
            "A gargantuan gate blocks your entry, the words \"Dungeon\" hang precariously \n" +
            "above the massive wooden doors. A small window slides open on the bottom left \n" +
            "of the door. A dark figure lurks behind it."
        };
        static string[] promptList = new string[]
        //!Array Prompt
        {
            //Beach - Prompt - 0
            "What Will You Do?\n" +
            "A) Check for washed-up goods\n" +
            "B) Investigate Mast\n" +
            "C) Investigate Mountains\n",

            //Shipwreck - Prompt - 1
            "What Will You Do?\n" +
            "A) Swim Out to the Wreckage\n" +
            "B) Turn Back\n" +
            "C) Continue to Observe\n",

            //Mountain Path - Prompt - 2
            "What Will You Do?\n" +
            "A) Follow the Path\n" +
            "B) Run Straight into the Woods\n" +
            "C) Attempt to make your own path into the Mountain\n",

            //Cave Mouth - Prompt - 3
            "What Will You Do?\n" +
            "A) Enter the Cave\n" +
            "B) Study the Jagged Rocks\n" +
            "C) Turn Back \n",

            //Tunnels - Prompt - 4
            "What Will You Do?\n" +
            "A) Go Down the Tunnel\n" +
            "B) Attack Tunnel\n" +
            "C) Hug the Tunnel\n",

            //Tunnel - Forks - Prompt - 5
            "What Will You Do?\n" +
            "A) Investigate the Screaming Tunnel\n" +
            "B) Investigate the Weeping Tunnel\n" +
            "C) Flee\n",

            //Tunnel - Screams - Prompt - 6
            "What Will You Do?\n" +
            "A) Go into Town\n" +
            "B) Avoid the Town\n" +
            "C) Turn Back\n",

            //Cave Town - Prompt - 7
            "What Will You Do?\n" +
            "A) Walk Around the Town\n" +
            "B) Investigate the Crowd\n" +
            "C) Head Towards the Tower\n",
            
            //Weeping Tunnel - Prompt - 8
            "What Will You Do?\n" +
            "A) Attempt to Scare the Creatures\n" +
            "B) Weep with Them\n" +
            "C) Turn Back\n",

            //Dungeon - Prompt - 9
            "What Will You Do?\n" +
            "A) Approach the Dark Figure\n" +
            "B) Charge at the Door\n" +
            "C) Attempt to Jump through the Window\n"
        };
        static void WelcomePlayer()
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
            Console.WriteLine("█                        A Text-based RPG                        █");                Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");    
            Console.ResetColor();
            Console.WriteLine("Hello, Adventurer!\nYour Adventure Shall Begin!\n-=Press Any Key=-");
            }
        static void SetColour()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
        
        static void AnswerHandler(string playerSelection, ref int locationIndex, out bool gameOver)
                    {
                        //int locationCompare;
                        //locationIndex
                        gameOver = false;
                        // ^ Necessary for error removal
                        switch(playerSelection)
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
                                if(locationIndex > 0) {locationIndex--;}
                                gameOver = true;
                                break;
                            }
                        }
                    }
        static void GameOverHandler()
            {
            Console.Clear();
            SetColour();
                Console.WriteLine("-=Game Over=- \n Thank you for playing!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(1);
            }
        }
}
