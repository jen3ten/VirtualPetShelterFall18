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

            //Copy of object for selected Manager or Volunteer
            Manager selectedManager = new Manager("");
            Volunteer selectedVolunteer = new Volunteer("");

            //Manually instantiate Manager objects and save in a list
            Manager managerJane = new Manager("Jane");
            Manager managerDarren = new Manager("Darren");
            VirtualPetShelter.managersList.Add(managerJane);
            VirtualPetShelter.managersList.Add(managerDarren);

            //Manually instantiate Volunteer objects and save in a list
            Volunteer volunteerBilly = new Volunteer("Billy");
            Volunteer volunteerSally = new Volunteer("Sally");
            VirtualPetShelter.volunteersList.Add(volunteerBilly);
            VirtualPetShelter.volunteersList.Add(volunteerSally);

            //Manually instantiate Pet objects and save in a list
            VirtualPet fluffball = new VirtualPet("FluffBall", "Fluffy kitty", 45, 49, 12);
            VirtualPet fluffer = new VirtualPet("Fluffer", "Floppy bunny", 100, 78, 65);
            VirtualPet fluffdog = new VirtualPet("FluffDog", "Doggie", 67, 92, 34);
            VirtualPetShelter.petsList.Add(fluffball);
            VirtualPetShelter.petsList.Add(fluffer);
            VirtualPetShelter.petsList.Add(fluffdog);

            Console.WriteLine("** Welcome to the Fluffy Virtual Pet Shelter **");
            Console.WriteLine("** ...serving fluffy animals since 2002.     **");

            do //Game loop.  Play while playGame is true.
            {
                Console.WriteLine();
                Console.WriteLine("What type of employee are you?");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Volunteer");
                Console.WriteLine("3. Exit the Program");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        selectedManager = Manager.SelectManager();
                        selectedManager.ManagerMenu();
                        break;
                    case 2:
                        selectedVolunteer = Volunteer.SelectVolunteer();
                        selectedVolunteer.VolunteerMenu();
                        break;
                    case 3:
                        playGame = false;
                        Console.WriteLine("Good Bye!");
                        break;
                    default:
                        Console.WriteLine("I don't know who you are.");
                        break;
                };
            } while (playGame);   
        } //End Main()
    }
}
