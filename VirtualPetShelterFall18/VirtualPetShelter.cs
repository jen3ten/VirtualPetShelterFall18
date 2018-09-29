using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    public class VirtualPetShelter //To store all pets and employees at the shelter
    {
        internal static List<VirtualPet> petsList;  //A list of Pets at the shelter
        internal static List<Manager> managersList;    //A list of Managers at the shelter
        internal static List<Volunteer> volunteersList;    //A list of Volunteers at the shelter

        static VirtualPetShelter()
        {
            petsList = new List<VirtualPet>();
            managersList = new List<Manager>();
            volunteersList = new List<Volunteer>();
        }
    }
}
