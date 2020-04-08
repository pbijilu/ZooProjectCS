using System;
using System.Collections.Generic;
using System.Linq;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Animals.Herbivores;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Creators;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Interfaces;
using Trainings.ConsoleApp.Zones;

namespace Trainings.ConsoleApp
{
    class Program
    {
        static Dictionary<Animal, Zone> allAnimals = new Dictionary<Animal, Zone>();
        static List<Zone> zones = new List<Zone>();

        static void ZoneInitializer()
        {
            zones.Add(new Zone(1, GroundType.Forest));
            zones.Add(new Zone(2, GroundType.Iceberg));
            zones.Add(new Zone(3, GroundType.Plains));
            zones.Add(new Zone(4, GroundType.TropicalForest));
            zones.Add(new Zone(5, GroundType.Water));
        }

        static Zone ZoneChooser()
        {
            Console.WriteLine("Select a zone:");

            for (int i = 0; i < zones.Count; i++)
            {
                Console.WriteLine($"Zone {i + 1}. {zones[i].ToString()}");
            }

            int zoneNumber = Convert.ToInt32(Console.ReadLine());

            return zones[zoneNumber-1];
        }

        static void ZoneViewer(Zone zone)
        {
            for (int i = 0; i < zone.Animals.Length; i++)
            {
                if (zone.Animals[i] != null) Console.WriteLine($"{i+1}. {zone.Animals[i]}");
            }
        }

        static void AnimalSelectionDisplayer(List<KeyValuePair<Animal,Zone>> listOfPairs)
        {
            if (listOfPairs.Any())
            {
                foreach (KeyValuePair<Animal, Zone> pair in listOfPairs)
                {
                    Console.WriteLine($"{pair.Key.ToString()} I sit in Zone {pair.Value.Id}. It's a {pair.Value.Ground} zone.");
                }
            }
            else Console.WriteLine("No animal found!");
        }

        static List<KeyValuePair<Animal,Zone>> AnimalCollectionFinder()
        {
            Console.WriteLine("Select parameter to find your animal:");
            Console.WriteLine("1. Find by name\n2. Find by species");

            while (true)
            {

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Please enter animals' name (or the beginning of it):");
                        string input = Console.ReadLine();
                        return allAnimals.Where(i => i.Key.Name.StartsWith(input)).ToList();
                    case "2":
                        Console.WriteLine("Please enter animal's species (or the beginning of it):");
                        input = Console.ReadLine();
                        return allAnimals.Where(i => i.Key.Species.ToString().StartsWith(input)).ToList();
                    default:
                        Console.WriteLine("Please select a number from the list");
                        break;
                }
            }
        }

        static Animal AnimalChooser()
        {
            Zone zone = ZoneChooser();
            ZoneViewer(zone);
            Console.WriteLine("Please select your animal by typing the correct number:");
            return zone.Animals[Convert.ToInt32(Console.ReadLine())-1];
        }

        static Animal AnimalCreator(Zone zone)
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
                switch (Console.ReadLine())
                {
                    case "1":
                        creator = new BearCreator(zone);
                        break;
                    case "2":
                        creator = new GorillaCreator(zone);
                        break;
                    case "3":
                        creator = new LionCreator(zone);
                        break;
                    case "4":
                        creator = new PenguinCreator(zone);
                        break;
                    case "5":
                        creator = new SealCreator(zone);
                        break;
                    case "6":
                        creator = new WolfCreator(zone);
                        break;
                    case "7":
                        creator = new ElephantCreator(zone);
                        break;
                    case "8":
                        creator = new GiraffeCreator(zone);
                        break;
                    case "9":
                        creator = new HippopotamusCreator(zone);
                        break;
                    case "10":
                        creator = new KoalaCreator(zone);
                        break;
                    case "11":
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
            Animal newAnimal = AnimalCreator(selectedZone);

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

        static void AnimalFeeder(Animal animal)
        {
            Console.WriteLine("Do you want to feed the animal? Enter [y]es or [n]o:");
            string input = Console.ReadLine();

            if (input == "y")
            {
                if (animal is Herbivore)
                {
                    Herbivore herbivore =  animal as Herbivore;
                    herbivore.GrassQuantity++;
                    Console.WriteLine("Some grass given");
                }
                if (animal is Predator)
                {
                    Predator predator = animal as Predator;
                    predator.MeatQuantity++;
                    Console.WriteLine("Some meat given");
                }
                if (animal is IFishEatable)
                {
                    Console.WriteLine("Do you want to give it some fish? Enter [y]es or [n]o:");
                    string secondInput = Console.ReadLine();

                    if (secondInput == "y")
                    {
                        IFishEatable fishEater = animal as IFishEatable;
                        fishEater.FishQuantity++;
                        Console.WriteLine("Some fish given");
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            ZoneInitializer();

            while (true)
            {
                Console.WriteLine("Hello! This is the Ultimate Zoo's main menu");
                Console.WriteLine("Select your task by entering the number:");
                Console.WriteLine("1. Add new animal to the base\n2. View current animals location\n3. View all animals\n4. Find animal by...\n5. Feed the animal");

                switch (Console.ReadLine())
                {
                    case "1":
                        AnimalPlacer();
                        break;
                    case "2":
                        ZoneViewer(ZoneChooser());
                        break;
                    case "3":
                        AnimalSelectionDisplayer(allAnimals.ToList());
                        break;
                    case "4":
                        AnimalSelectionDisplayer(AnimalCollectionFinder());
                        break;
                    case "5":
                        AnimalFeeder(AnimalChooser());
                        break;
                    default:
                        Console.WriteLine("Please select a number from the list");
                        break;
                }
            }
        }
    }
}
