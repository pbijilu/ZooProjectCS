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

        public Gorilla() : base()
        {
            Ground = GroundType.TropicalForest;
            Species = SpeciesType.Gorilla;
        }
    }
}
