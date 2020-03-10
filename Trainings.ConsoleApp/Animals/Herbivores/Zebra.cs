using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    class Zebra : Herbivore
    {
        public Zebra(string name, int age, Sex sex, int grassQuantity) : base(name, age, sex, grassQuantity)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Zebra;
        }

        public Zebra() : base("Marina", 7, Sex.Female, 0)
        {
            Ground = GroundType.Plains;
            Species = SpeciesType.Zebra;
        }
    }
}
