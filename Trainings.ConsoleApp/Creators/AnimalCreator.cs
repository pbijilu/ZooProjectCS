using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Creators
{
    abstract class AnimalCreator
    {
        public AnimalCreator()
        {
            Console.WriteLine("Enter animal's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter animal's age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select animal's sex: ('1' for male, '2' for female)");
            Sex sex = (Sex)Convert.ToInt32(Console.ReadLine());
        }
        public abstract Animal Create();
    }
}
