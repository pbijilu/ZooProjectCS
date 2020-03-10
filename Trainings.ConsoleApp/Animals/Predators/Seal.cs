using System;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Interfaces;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Seal : Predator, IFishEatable
    {
        public Seal(string name, int age, Sex sex, int meatQuantity, int fishQuantity) : base(name, age, sex, meatQuantity)
        {
            Ground = GroundType.Water;
            Species = SpeciesType.Seal;
            this.FishQuantity = fishQuantity;
        }

        public Seal() : base("Zhanna", 5, Sex.Female, 0)
        {
            Ground = GroundType.Water;
            Species = SpeciesType.Seal;
            this.FishQuantity = 6;
        }

        public int FishQuantity { get; set; }

        public void EatFish()
        {
            Console.WriteLine("Trying to eat...");
            if (FishQuantity > 0)
            {
                Console.WriteLine("Success! Had some tasty meat!");
                FishQuantity--;
            }
            else
            {
                Console.WriteLine("No meat slices available.");
            }
        }

        public override string ToString()
        {
            string s = base.ToString() + $" I have {FishQuantity} fish slices.";
            return s;
        }
    }
}
