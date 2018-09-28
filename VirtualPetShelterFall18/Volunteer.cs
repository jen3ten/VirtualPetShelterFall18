using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class Volunteer : Employee //Volunteer information derived from Employee
    {
        public int Hours { get; set; } //volunteer work hours per week
        public string Specialty { get; set; } //volunteer specialty

        public Volunteer(string name)
        {
            this.EmployeeName = name;
        }

        public override void EnterWorkHours()
        {
            //Enter work hours for the week.  Work hours must not exceed maximum weekly hours
            int MaxWeeklyHours = 20;
        }

        public override void EditName()
        {
            throw new NotImplementedException();
        }

        public void FeedPets()
        {
            //Do feed stuff here
        }

        public void WaterPets()
        {
            //Do water stuff here
        }
    }
}
