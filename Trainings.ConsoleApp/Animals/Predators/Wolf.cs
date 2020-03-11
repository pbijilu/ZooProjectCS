using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Wolf : Predator
    {
        public Wolf() : base()
        {
            Ground = GroundType.Forest;
            Species = SpeciesType.Wolf;
        }
    }
}
