using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Elephant : Herbivore
    {
        public Elephant() : base()
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Elephant;
        }
    }
}
