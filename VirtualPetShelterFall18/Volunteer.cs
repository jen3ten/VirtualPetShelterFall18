using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class Volunteer : Employee //Volunteer information derived from Employee
    {
        //Properties
        public int MaxHours { get; set; } //maximum volunteer work hours per week
        public string Specialty { get; set; } //volunteer specialty

        //Constructors
        public Volunteer(string name)
        {
            this.EmployeeName = name;
        }

        //Static Methods
        internal static Volunteer SelectVolunteer()
        {
            bool repeatQuestion;
            int volNum;

            do
            {
                repeatQuestion = false;

                Console.WriteLine();
                Console.WriteLine("Which volunteer are you?");
                foreach (Volunteer volunteer in VirtualPetShelter.volunteersList)
                {
                    Console.WriteLine("{0}. {1}, who specializes in {2}", VirtualPetShelter.volunteersList.IndexOf(volunteer) + 1, volunteer.EmployeeName, volunteer.Specialty);
                }

                volNum = int.Parse(Console.ReadLine());
                if (volNum < 1 || volNum > VirtualPetShelter.volunteersList.Count)
                {
                    Console.WriteLine("I don't know who you are.  Try again.");
                    repeatQuestion = true;
                }
            } while (repeatQuestion);

            return VirtualPetShelter.volunteersList[volNum - 1];
        } //end of SelectManager()

        //Instance Methods
        internal void VolunteerMenu()
        {
            bool repeatQuestion;

            do
            {
                repeatQuestion = true;
                Console.WriteLine();
                Console.WriteLine("Hi, Volunteer {0}! What would you like to do?", EmployeeName);
                Console.WriteLine("1. Edit name");
                Console.WriteLine("2. Enter work hours");
                Console.WriteLine("3. View status of pets");
                Console.WriteLine("4. Feed pets");
                Console.WriteLine("5. Water pets");
                Console.WriteLine("6. Play with pets");
                Console.WriteLine("7. Rest the pets");
                Console.WriteLine("8. Return to Main Menu");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        EditName();
                        break;
                    case 2:
                        EnterWorkHours();
                        break;
                    case 3:
                        ViewStatus();
                        break;
                    case 4:
                        FeedPets();
                        break;
                    case 5:
                        WaterPets();
                        break;
                    case 6:
                        PlayPets();
                        break;
                    case 7:
                        RestPets();
                        break;
                    case 8:
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
            //Enter work hours for the week.  Work hours must not exceed maximum weekly hours
            bool repeatQuestion;
            int hours;

            Console.WriteLine();
            Console.WriteLine("Vounteer {0}, you have worked {1} hours this week", EmployeeName, WorkHours);
            do
            {
                repeatQuestion = false;
                Console.Write("Please type your new work hours here: ");
                hours = int.Parse(Console.ReadLine());
                if(hours > MaxHours)
                {
                    Console.WriteLine("{0}, you may not work more than {1} hours in a week.", EmployeeName, MaxHours);
                    repeatQuestion = true;
                }
                else
                {
                    WorkHours = hours;
                }
            } while (repeatQuestion);
            Console.WriteLine("Your work hours have been changed to {0}", WorkHours);
        } //End of EditWorkHours()

        public void ViewStatus()
        {
            Console.WriteLine();
            Console.WriteLine("Vounteer {0}, this is the status of your pets:", EmployeeName);
            Console.WriteLine("{0,-15}{1, -15}{2,10}{3,10}{4,10}", "Pet Name", "Description", "Hunger", "Fatigue", "Health");
            Console.WriteLine("-----------------------------------------------------------------");
            foreach(VirtualPet pet in VirtualPetShelter.petsList)
            {
                Console.WriteLine("{0,-15}{1, -15}{2,10}{3,10}{4,10}", pet.Name, pet.Description, pet.Hunger, pet.Fatigue, pet.Health);
            }
        } //End of ViewStatus()

        public void FeedPets()
        {
            foreach(VirtualPet pet in VirtualPetShelter.petsList)
            {
                pet.FeedMe();
            }
            Console.WriteLine("All pets have been fed!");
            ViewStatus();
        } //End of FeedPets()

        public void WaterPets()
        {
            foreach (VirtualPet pet in VirtualPetShelter.petsList)
            {
                pet.WaterMe();
            }
            Console.WriteLine("All pets have been given water!");
            ViewStatus();
        } //End of WaterPets()

        public void PlayPets()
        {
            foreach (VirtualPet pet in VirtualPetShelter.petsList)
            {
                pet.ExerciseMe();
            }
            Console.WriteLine("All pets have been played with!");
            ViewStatus();
        } //End of PlayPets()

        public void RestPets()
        {
            foreach (VirtualPet pet in VirtualPetShelter.petsList)
            {
                pet.RestMe();
            }
            Console.WriteLine("All pets are now resting!");
            ViewStatus();
        } //End of RestPets()

    }
}
