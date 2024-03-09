using System;
using System.Runtime.InteropServices;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string GameAction;
            bool InCombat = false;

            //Start the Game
            Console.WriteLine("Welcome to D&D!");

            //Game Loop
            while (true)
            {
                //Game Action Choosing
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Skill Check");
                Console.WriteLine("2. Saving Throws");
                Console.WriteLine("3. Enter Combat");
                Console.WriteLine("4. Short Rest");
                Console.WriteLine("4. Long Rest");
                Console.WriteLine("or type 'EXIT' to Quit.");

                GameAction = Console.ReadLine();

                //Exit
                if (GameAction == "EXIT")
                {
                    break;
                }
                //Skill Check
                else if (GameAction == "1")
                {
                    Console.WriteLine("What Skill?");
                }
                //Not re
                else
                {
                    Console.WriteLine("Game Action not defined.");
                }
            }
        }
    }
}
