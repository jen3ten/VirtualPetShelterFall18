﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterFall18
{
    class VirtualPet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hunger { get; set; }
        public int Fatigue { get; set; }
        public int Health { get; set; }

        //Constructors
        public VirtualPet()
        {
        }

        public VirtualPet(string petName, string petDesc)
        {
            this.Name = petName;
            this.Description = petDesc;
        }

        public VirtualPet(string petName, string petDesc, int petHunger, int petFatigue, int petHealth)
        {
            this.Name = petName;
            this.Description = petDesc;
            this.Hunger = petHunger;
            this.Fatigue = petFatigue;
            this.Health = petHealth;
        }

        //Methods
        public void FeedMe()
        {
            this.Hunger = Hunger - 21;
            this.Fatigue = Fatigue + 1;
        }

        public void WaterMe()
        {
            this.Hunger = Hunger - 9;
        }

        public void ExerciseMe()
        {
            this.Hunger = Hunger + 30;
            this.Fatigue = Fatigue + 42;
            this.Health = Health + 13;
        }

        public void RestMe()
        {
            this.Fatigue = Fatigue - 50;
            this.Health = Health + 15;
        }
    }
}
