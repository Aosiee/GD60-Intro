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

            Player newPlayer = new Player();

            Console.WriteLine("");

            int locX = 0;
            int locY = 0;

            //initialize thegame map
            Map theMap = new Map(10);
            Location[,] gameMap = new Location[10,10];

            Location loc = theMap.LocationAt(locX,locY);
            
            //gameMap = InitMap();

            bool gameOver = false;
            int locationIndex = 0;
            while(!gameOver)
            {
                //X & Y
                Console.WriteLine( theMap.DescAt( newPlayer._playerLocation[0], newPlayer._playerLocation[1]));

            //


                    //!Displays the location & makes it pretty
                    //SetColour();
                    Console.WriteLine("-=Story=-");
                    Console.ResetColor();

                    //Location loc = theMap.LocationAt (locX, locY);

                    Console.WriteLine( theMap.ShowDescAt(locX, locY));
                    Console.WriteLine( theMap.DescAt(locX, locY));

                    
                    //!Displays the prompt & recieves answer & makes it pretty as well :)
        
                    string playerSelection = Console.ReadLine().ToLower();
                    string answer = playerSelection;  

                    //Handles the Options that the player can select
                    AnswerHandler(playerSelection, ref locationIndex, out gameOver);

                    if (newPlayer.UpdatePlayerLocation (answer))
                        {
                            Console.WriteLine("You moved");
                        }

                    // This makes sure that the program doesn't go over the Array as said in README.txt
                    if(locationIndex == 9) { gameOver = true; goto Endgame; }
                    else if (locationIndex == 10) { gameOver = true; goto Endgame; }
                }
            Endgame: GameOverHandler();
            }
            // Handles Game Over Situations
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
            Console.WriteLine("█                        A Text-based RPG                        █");                
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");    
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