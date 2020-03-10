using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Predators
{
    class Lion : Predator
    {
        public Lion(string name, int age, Sex sex, int meatQuantity) : base(name, age, sex, meatQuantity)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Lion;
        }

        public Lion() : base("Leva", 7, Sex.Male, 0)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Lion;
        }
    }
}
