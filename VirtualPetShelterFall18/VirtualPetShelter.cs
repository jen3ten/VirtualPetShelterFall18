using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    public class VirtualPetShelter //To store all pets and employees at the shelter
    {
        public static List<string> pets;  //A list of Pets at the shelter
        public static List<string> employees;    //A list of Employees at the shelter

        static VirtualPetShelter()
        {
            pets = new List<string>();
            employees = new List<string>();
        }
    }
}
