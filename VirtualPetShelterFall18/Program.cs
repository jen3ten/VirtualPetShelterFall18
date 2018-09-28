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

            Manager managerJane = new Manager("Jane");
            Manager managerDarren = new Manager("Darren");
            Volunteer volunteerBilly = new Volunteer("Billy");
            Volunteer volunteerSally = new Volunteer("Sally");
            VirtualPet fluffball = new VirtualPet("FluffBall", "Fluffy kitty", 45, 49, 12);
            VirtualPet fluffer = new VirtualPet("Fluffer", "Floppy bunny", 100, 78, 65);
            VirtualPet fluffdog = new VirtualPet("FluffDog", "Doggie", 67, 92, 34);

            Console.WriteLine("** Welcome to the Fluffy Virtual Pet Shelter **");
            Console.WriteLine("** ...serving fluffy animals since 2002.     **");
            Console.WriteLine();

            Console.WriteLine("Here is a list of employees who work here:");
            foreach (string name in VirtualPetShelter.employees)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Here is a list of pets who live here:");
            foreach (string pet in VirtualPetShelter.pets)
            {
                Console.WriteLine(pet);
            }


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
