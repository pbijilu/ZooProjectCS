using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals
{
    abstract class Animal
    {
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }

        public GroundType Ground { get; set; }

        public SpeciesType Species { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }

        public abstract void Eat();

        public override string ToString()
        {
            string s = $"Hello! My name is {Name}. I am a {Species}. I am {Age} years old. I am a {Sex}.";
            return s;
        }

    }
}
