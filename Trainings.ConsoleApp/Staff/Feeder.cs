using System;
using Trainings.ConsoleApp.Animals.Herbivores;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Interfaces;

namespace Trainings.ConsoleApp.Staff
{
    class Feeder : Worker
    {
        public void GiveMeat(Predator Predator)
        {
            Console.WriteLine("Feeding a predator...");

            if (Predator.MeatQuantity < 10)
            {
                Console.WriteLine($"Success! Predator now has {Predator.MeatQuantity} meat slices.");
                Predator.MeatQuantity++;
            }
            else
            {
                Console.WriteLine("Nah, this guy already has too much meat!");
            }
        }

        public void GiveFish(IFishEatable FishEater)
        {
            Console.WriteLine("Feeding a fish eater...");

            if (FishEater.FishQuantity < 10)
            {
                Console.WriteLine($"Success! Predator now has {FishEater.FishQuantity} fish slices.");
                FishEater.FishQuantity++;
            }
            else
            {
                Console.WriteLine("Nah, this guy already has too much fish!");
            }
        }

        public void GiveGrass(Herbivore Herbivore)
        {
            Console.WriteLine("Feeding a herbivore...");

            if (Herbivore.GrassQuantity < 10)
            {
                Console.WriteLine($"Success! Predator now has {Herbivore.GrassQuantity} grass bales.");
                Herbivore.GrassQuantity++;
            }
            else
            {
                Console.WriteLine("Nah, this guy already has too much.");
            }
        }
    }
}
