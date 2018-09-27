using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;

            Console.WriteLine("** Welcome to the Fluffy Virtual Pet Shelter **");
            Console.WriteLine("** ...serving fluffy animals since 2002.     **");
            Console.WriteLine();

            do //Game loop.  Play while playGame is true.
            {
                //Volunteer feed, water, view status, play
                //Manager adopt pet, view status, play

                //Read user input

                //Write output to console
                Console.WriteLine("What type of employee are you?");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Volunteer");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        //do something
                        break;
                    case 2: 
                        //do something
                        break;
                    default:
                        Console.WriteLine("I don't know who you are.");
                        break;
                };

                Console.Write("Would you like to play again? (Y or N): ");
                playGame = (Console.ReadLine().ToLower() == "y") ? true : false;

            } while (playGame);
            

        }

        
    }
}
