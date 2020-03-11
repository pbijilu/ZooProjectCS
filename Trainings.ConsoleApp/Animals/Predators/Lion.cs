using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Lion : Predator
    {
        public Lion() : base()
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Lion;
        }
    }
}
