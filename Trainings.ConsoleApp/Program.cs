using System;
using System.Collections.Generic;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Animals.Herbivores;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Creators;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Staff;

namespace Trainings.ConsoleApp
{
    class Program
    {
        static Animal AnimalCreator()
        {
            Creator creator;
            int i = 1;

            Console.WriteLine("Enter animal's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter animal's age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select animal's sex: ('1' for male, '2' for female");
            Sex sex = (Sex)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to give it some food? Please enter the food quantity ('0' for no food)");
            int foodQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select species from the list and enter the number:");
            foreach (SpeciesType species in Enum.GetValues(typeof(SpeciesType)))
            {
                Console.WriteLine($"{i}. {species}");
                i++;
            }

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case (1):
                    creator = new BearCreator();
                    break;
                case (2):
                    creator = new BearCreator();
                    break;
                default:
                    creator = new BearCreator();
                    break;
            }

            return creator.Create(name, age, sex, foodQuantity);
        }
        static void Main(string[] args)
        {
            var list = new List<Animal>();
            while (true)
            {
                Console.WriteLine("Hello! This is the Ultimate Zoo's main menu");
                Console.WriteLine("Select your task by entering the first letter:");
                Console.WriteLine("1. Add new animal to the base\n2. View current animals location\n3. Feed the animal\n4. Clean the cage");

                switch (Console.ReadLine()[0])
                {
                    case 'A':
                        list.Add(AnimalCreator());
                        break;
                    case 'V':
                        foreach(Animal a in list)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case 'F':
                        Console.WriteLine();
                        break;
                    case 'C':
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
