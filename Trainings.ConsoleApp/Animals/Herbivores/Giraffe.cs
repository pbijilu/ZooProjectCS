using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Giraffe : Herbivore
    {
        public Giraffe(string name, int age, Sex sex, int grassQuantity) : base(name, age, sex, grassQuantity)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Giraffe;
        }

        public Giraffe() : base("Melman", 12, Sex.Male, 0)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Giraffe;
        }
    }
}
