using System;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Interfaces;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Penguin : Predator, IFishEatable
    {
        public Penguin(string name, int age, Sex sex, int meatQuantity, int fishQuantity) : base(name, age, sex, meatQuantity)
        {
            Ground = GroundType.Iceberg;
            Species = SpeciesType.Penguin;
            this.FishQuantity = fishQuantity;
        }

        public Penguin() : base("Harold", 3, Sex.Male, 0)
        {
            Ground = GroundType.Iceberg;
            Species = SpeciesType.Penguin;
            this.FishQuantity = 3;

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

        public override void Eat()
        {
            Console.WriteLine("Trying to eat...");
            Console.WriteLine();
            Console.WriteLine("Though I'm a predator I'd love to eat some fish instead!");
        }
        public override string ToString()
        {
            string s = base.ToString() + $" I have {FishQuantity} fish slices.";
            return s;
        }
    }
}
