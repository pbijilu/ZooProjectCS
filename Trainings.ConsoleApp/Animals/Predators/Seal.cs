using System;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Interfaces;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Seal : Predator, IFishEatable
    {
        public Seal() : base()
        {
            Ground = GroundType.Water;
            Species = SpeciesType.Seal;

            Console.WriteLine("Do you want to give it some fish? Please enter the fish quantity ('0' for no fish)");
            FishQuantity = Convert.ToInt32(Console.ReadLine());
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
            if (MeatQuantity > 0)
            {
                Console.WriteLine("I'd really prefer some fish instead, but if you insist...");
                MeatQuantity--;
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
