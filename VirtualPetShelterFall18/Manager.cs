using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class Manager : Employee  //Manager class derived from Employee
    {
        public int NumVolunteers { get; set; }  //The number of volunteers the Manager supervises

        public Manager(string name)
        {
            this.EmployeeName = name;
            VirtualPetShelter.employees.Add(name);
        }

        public override void EnterWorkHours()
        {
            //Can work more than 40 hours
        }

        public override void EditName()
        {
            throw new NotImplementedException();
        }

        public void AdoptPet()
        {
            //Do adoption stuff here
            //List pet names and descriptions; allow user to select one
        }
    }
}
