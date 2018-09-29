using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class Manager : Employee  //Manager class derived from Employee
    {
        //Properties
        public int NumVolunteers { get; set; }  //The number of volunteers the Manager supervises

        //Constructors
        public Manager(string name)
        {
            this.EmployeeName = name;
        }

        //Static Methods
        internal static Manager SelectManager()
        {
            bool repeatQuestion;
            int managerNum;

            do
            {
                repeatQuestion = false;

                Console.WriteLine();
                Console.WriteLine("Which manager are you?");
                foreach (Manager manager in VirtualPetShelter.managersList)
                {
                    Console.WriteLine("{0}. {1}", VirtualPetShelter.managersList.IndexOf(manager) + 1, manager.EmployeeName);
                }

                managerNum = int.Parse(Console.ReadLine());
                if (managerNum < 1 || managerNum > VirtualPetShelter.managersList.Count)
                {
                    Console.WriteLine("I don't know who you are.  Try again.");
                    repeatQuestion = true;
                }
            } while (repeatQuestion);

            return VirtualPetShelter.managersList[managerNum - 1];
        } //end of SelectManager()

        //Instance Methods
        internal void ManagerMenu()
        {
            bool repeatQuestion;

            do
            {
                repeatQuestion = true;
                Console.WriteLine();
                Console.WriteLine("Hi, Manager {0}! What would you like to do?", EmployeeName);
                Console.WriteLine("1. Edit name");
                Console.WriteLine("2. Enter work hours");
                Console.WriteLine("3. Adopt pet");
                Console.WriteLine("4. Return to Main Menu");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        EditName();
                        break;
                    case 2:
                        EnterWorkHours();
                        break;
                    case 3:
                        AdoptPet();
                        break;
                    case 4:
                        repeatQuestion = false;
                        break;
                    default:
                        Console.WriteLine("I don't know what you want to do.");
                        break;
                };
            } while (repeatQuestion);
        } //end of ManagerMenu()

        public override void EditName()
        {
            Console.WriteLine();
            Console.WriteLine("Your name is {0}", EmployeeName);
            Console.Write("Please type your new name here: ");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Your name has been changed to {0}", EmployeeName);
        } //end of EditName()

        public override void EnterWorkHours()
        {
            Console.WriteLine();
            Console.WriteLine("Manager {0}, you have worked {1} hours this week", EmployeeName, WorkHours);
            Console.Write("Please type your new work hours here: ");
            WorkHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Your work hours have been changed to {0}", WorkHours);
        } //End of EditWorkHours()

        public void AdoptPet()
        {
            bool repeatQuestion;
            int petNum;

            do
            {
                repeatQuestion = false;

                Console.WriteLine();
                Console.WriteLine("Manager {0}, which pet will be adopted?", EmployeeName);
                foreach (VirtualPet pet in VirtualPetShelter.petsList)
                {
                    Console.WriteLine("{0}. {1}, the {2}", VirtualPetShelter.petsList.IndexOf(pet) + 1, pet.Name, pet.Description);
                }
                petNum = int.Parse(Console.ReadLine());
                if (petNum < 1 || petNum > VirtualPetShelter.petsList.Count)
                {
                    Console.WriteLine("That pet isn't listed.  Try again.");
                    repeatQuestion = true;
                }
            } while (repeatQuestion);

            Console.WriteLine("Congratulations, {0}! You have been adopted.", VirtualPetShelter.petsList[petNum - 1].Name);
        } //End of AdoptPet()
    }
}
