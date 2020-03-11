using System;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Interfaces;

namespace Trainings.ConsoleApp.Animals.Predators
{
    abstract class Predator : Animal
    {
        public Predator() : base ()
        {
            Console.WriteLine("Do you want to give it some meat? Please enter the meat quantity ('0' for no meat)");
            MeatQuantity = Convert.ToInt32(Console.ReadLine());
        }

        public int MeatQuantity { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Trying to eat...");
            if (MeatQuantity > 0)
            {
                Console.WriteLine("Success! Had some tasty meat!");
                MeatQuantity--;
            }
            else
            {
                Console.WriteLine("No meat slices available.");
            }
        }

        public override string ToString()
        {
            string s = base.ToString() + $" I have {MeatQuantity} meat slices.";
            return s;
        }
    }
}
