using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class PetInfo : VirtualPet //Derived from Virtual Pet; info about all Pets (in shelter and not)
    {
        public string Type { get; set; }    //The type of pet
        public string Diet { get; set; }    //The diet of the pet
    }
}
