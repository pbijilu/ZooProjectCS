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
        public Koala() : base()
        {
            Ground = GroundType.TropicalForest;
            Species = SpeciesType.Koala;
        }
    }
}
