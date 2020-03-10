using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Koala : Herbivore
    {
        public Koala(string name, int age, Sex sex, int grassQuantity) : base(name, age, sex, grassQuantity)
        {
            Ground = GroundType.TropicalForest;
            Species = SpeciesType.Koala;
        }

        public Koala() : base("Gary", 4, Sex.Male, 0)
        {
            Ground = GroundType.TropicalForest;
            Species = SpeciesType.Koala;
        }
    }
}
