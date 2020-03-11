using System;
using System.Collections.Generic;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Animals.Herbivores;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Creators;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Staff;
using Trainings.ConsoleApp.Zones;

namespace Trainings.ConsoleApp
{
    class Program
    {
        static Dictionary<Animal, Zone> allAnimals = new Dictionary<Animal, Zone>();
        static List<Zone> zones = new List<Zone>();

        static void ZoneInitializer()
        {
            zones.Add(new Zone(GroundType.Forest));
            zones.Add(new Zone(GroundType.Iceberg));
            zones.Add(new Zone(GroundType.Plains));
            zones.Add(new Zone(GroundType.TropicalForest));
            zones.Add(new Zone(GroundType.Water));
        }

        static Zone ZoneChooser()
        {
            Console.WriteLine("Select a zone to place the animal there:");

            for (int i = 0; i < zones.Count; i++)
            {
                Console.WriteLine($"Zone {i + 1}. {zones[i].ToString()}");
            }

            int zoneNumber = Convert.ToInt32(Console.ReadLine());

            return zones[zoneNumber-1];
        }

        static void ZoneViewer()
        {
            Console.WriteLine("Select a zone to view its animals:");

            for (int i = 0; i < zones.Count; i++)
            {
                Console.WriteLine($"Zone {i + 1}. {zones[i].ToString()}");
            }

            int zoneNumber = Convert.ToInt32(Console.ReadLine());

            foreach (Animal a in zones[zoneNumber-1].Animals)
            {
                if (a != null) Console.WriteLine(a);
            }
        }

        static Animal AnimalChooser(Zone zone)
        {
            Creator creator = null;

            int i = 1;
            Console.WriteLine("Please select species from the list and enter the number:");
            foreach (SpeciesType species in Enum.GetValues(typeof(SpeciesType)))
            {
                Console.WriteLine($"{i}. {species}");
                i++;
            }

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case (1):
                        creator = new BearCreator(zone);
                        break;
                    case (2):
                        creator = new GorillaCreator(zone);
                        break;
                    case (3):
                        creator = new LionCreator(zone);
                        break;
                    case (4):
                        creator = new PenguinCreator(zone);
                        break;
                    case (5):
                        creator = new SealCreator(zone);
                        break;
                    case (6):
                        creator = new WolfCreator(zone);
                        break;
                    case (7):
                        creator = new ElephantCreator(zone);
                        break;
                    case (8):
                        creator = new GiraffeCreator(zone);
                        break;
                    case (9):
                        creator = new HippopotamusCreator(zone);
                        break;
                    case (10):
                        creator = new KoalaCreator(zone);
                        break;
                    case (11):
                        creator = new ZebraCreator(zone);
                        break;
                    default:
                        Console.WriteLine("No such animal available! Please try again");
                        break;
                }
                if (creator != null) break;
            }

            return creator.Create();
        }

        static void AnimalPlacer()
        {
            Zone selectedZone = ZoneChooser();
            Animal newAnimal = AnimalChooser(selectedZone);

            if (newAnimal != null)
            {
                for (int i = 0; i < selectedZone.Animals.Length; i++)
                {
                
                    if (selectedZone.Animals[i] == null)
                    {
                        selectedZone.Animals[i] = newAnimal;
                        break;
                    }
                }
                allAnimals.Add(newAnimal, selectedZone);
            }
        }

        static void AllAnimalsViewer()
        {

        }

        static void Main(string[] args)
        {
            ZoneInitializer();

            while (true)
            {
                Console.WriteLine("Hello! This is the Ultimate Zoo's main menu");
                Console.WriteLine("Select your task by entering the first letter:");
                Console.WriteLine("1. Add new animal to the base\n2. View current animals location\n3. View all animals\n4. Feed the animal\n5. Clean the cage");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AnimalPlacer();
                        break;
                    case 2:
                        ZoneViewer();
                        break;
                    case 3:
                        AllAnimalsViewer();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Please select a number from the list");
                        break;
                }
            }
        }
    }
}
