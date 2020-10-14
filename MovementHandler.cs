//Copyright (C) 2020 Felipe Lara

using System;

namespace adventure
{
    public class MovementHandler
    {
        //private variables
        //public properties
            public string playerSelection = "blank";
            public bool endGame = false;

        //Constructor
        public MovementHandler(bool testGameOver){}

        public static bool handleAnswer (bool didChange, out string playerSelection, out bool testGameOver)
                    {
                        playerSelection = Console.ReadLine().ToLower();
                        testGameOver = false;
                        switch(playerSelection)
                        {
                            case "a":
                            {
                                Console.WriteLine("Option A ");
                                if(Options.DEBUG_MODE == true){Console.Write("- Y++");}
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }

                            case "b":
                            {
                                Console.WriteLine("Option B ");
                                if(Options.DEBUG_MODE == true){Console.Write("- X++");}
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }

                            case "c":
                            {
                                Console.WriteLine("Option C ");
                                if(Options.DEBUG_MODE == true){Console.Write("- X--");}
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }      

                            case "d":
                            {
                                Console.WriteLine("Option D ");
                                if(Options.DEBUG_MODE == true){Console.Write("- Y--");}
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }
                            //This allows exit to happen, no remove
                            case "exit":
                            {
                                testGameOver = true;
                                return testGameOver;
                            }
                            //For Riddle To cause no error
                            case "one":break;
                            case "1":break;
                            // This is so incase someone mis-types they can retry
                            default:
                            {
                                Console.WriteLine("Input Error. Please Try again");
                                Console.ReadKey();
                                Console.Clear();
                                //endGame = true;
                                break;
                            }   
                    }     
                        return didChange;      
        }
    }
}