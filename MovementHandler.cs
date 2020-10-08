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
        public MovementHandler(bool testGameOver)
            {

            }
        public static bool handleAnswer (bool didChange, out string playerSelection, out bool testGameOver)
                    {
                        playerSelection = Console.ReadLine().ToLower();
                        testGameOver = false;
                        switch(playerSelection)
                        {
                            case "a":
                            {
                                Console.WriteLine("Option A - Y++");
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }

                            case "b":
                            {
                                Console.WriteLine("Option B - X++");
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }

                            case "c":
                            {
                                Console.WriteLine("Option C - X--");
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }      

                            case "d":
                            {
                                Console.WriteLine("Option D - Y--");
                                Console.ReadKey();
                                Console.Clear();
                                didChange = true;
                                break;
                            }
                            case "exit":
                            {
                                testGameOver = true;
                                return testGameOver;
                            }

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