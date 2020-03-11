using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Zebra : Herbivore
    {
        public Zebra() : base()
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Zebra;
        }
    }
}
