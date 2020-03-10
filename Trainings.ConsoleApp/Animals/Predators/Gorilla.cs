using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Gorilla : Predator
    {
        public Gorilla(string name, int age, Sex sex, int meatQuantity) : base(name, age, sex, meatQuantity)
        {
            Ground = GroundType.TropicalForest;
            Species = SpeciesType.Gorilla;
        }

        public Gorilla() : base("Galya", 25, Sex.Female, 0)
        {
            Ground = GroundType.TropicalForest;
            Species = SpeciesType.Gorilla;
        }
    }
}
