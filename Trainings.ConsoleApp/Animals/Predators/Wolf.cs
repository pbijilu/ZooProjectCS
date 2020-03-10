using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Wolf : Predator
    {
        public Wolf(string name, int age, Sex sex, int meatQuantity) : base(name, age, sex, meatQuantity)
        {
            Ground = GroundType.Forest;
            Species = SpeciesType.Wolf;
        }

        public Wolf() : base("Zhorik", 6, Sex.Male, 0)
        {
            Ground = GroundType.Forest;
            Species = SpeciesType.Wolf;
        }
    }
}
