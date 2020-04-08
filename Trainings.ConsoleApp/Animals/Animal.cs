using System;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals
{
    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Enter animal's name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter animal's age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select animal's sex: ('1' for male, '2' for female)");
            Sex = (Sex)Convert.ToInt32(Console.ReadLine());
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
