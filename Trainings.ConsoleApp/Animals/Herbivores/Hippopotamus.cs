using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Hippopotamus : Herbivore
    {
        public Hippopotamus() : base()
        {
            Ground = GroundType.Water;
            Species = SpeciesType.Hippopotamus;
        }
    }
}
