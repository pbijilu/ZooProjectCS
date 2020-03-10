using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Hippopotamus : Herbivore
    {
        public Hippopotamus(string name, int age, Sex sex, int grassQuantity) : base(name, age, sex, grassQuantity)
        {
            Ground = GroundType.Water;
            Species = SpeciesType.Hippopotamus;
        }

        public Hippopotamus() : base("Gloria", 30, Sex.Female, 0)
        {
            Ground = GroundType.Water;
            Species = SpeciesType.Hippopotamus;
        }
    }
}
