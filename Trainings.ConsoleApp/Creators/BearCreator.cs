using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Creators
{
    class BearCreator : Creator
    {
        public override Animal Create(string name, int age, Sex sex, int meatQuantity)
        {
            return new Bear(name, age, sex, meatQuantity);
        }
    }

    class PenguinCreator : Creator, IFishEatableCreator
    {
        public override Animal Create(string name, int age, Sex sex, int meatQuantity)
        {
            return new Penguin();
        }

        public Animal Create(string name, int age, Sex sex, int foodQuantity, int fishQuantity)
        {
            Console.WriteLine("Do you want to give some fish to the animal?");
            Console.ReadLine();

            return new Penguin();
        }
    }
}
