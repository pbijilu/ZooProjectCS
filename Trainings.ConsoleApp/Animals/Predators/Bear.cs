using System;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Bear : Predator
    {
        public Bear() : base()
        {
            Ground = GroundType.Forest;
            Species = SpeciesType.Bear;
        }
    }
}
