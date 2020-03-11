using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Giraffe : Herbivore
    {
        public Giraffe() : base()
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Giraffe;
        }
    }
}
