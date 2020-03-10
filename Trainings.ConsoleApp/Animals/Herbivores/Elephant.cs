using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Elephant : Herbivore
    {
        public Elephant(string name, int age, Sex sex, int grassQuantity) : base(name, age, sex, grassQuantity)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Elephant;
        }

        public Elephant() : base("Kolya", 45, Sex.Male, 0)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Elephant;
        }
    }
}
