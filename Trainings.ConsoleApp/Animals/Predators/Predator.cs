using System;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Interfaces;

namespace Trainings.ConsoleApp.Animals.Predators
{
    abstract class Predator : Animal
    {
        public Predator(string name, int age, Sex sex, int meatQuantity) : base (name, age, sex)
        {
            this.MeatQuantity = meatQuantity;
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
