using System;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Bear : Predator
    {
        public Bear(string name, int age, Sex sex, int meatQuantity) : base(name, age, sex, meatQuantity)
        {
            Ground = GroundType.Forest;
            Species = SpeciesType.Bear;
        }

        public Bear(int age, Sex sex) : base("Misha", age, sex, 0)
        {
            Ground = GroundType.Forest;
            Species = SpeciesType.Bear;
        }
    }
}
