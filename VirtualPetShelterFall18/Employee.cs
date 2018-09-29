using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    public abstract class Employee //Base class with 2 abstract methods
    {
        public string EmployeeName { get; set; }
        public int WorkHours { get; set; }

        public abstract void EnterWorkHours();
        public abstract void EditName();

    }
}
