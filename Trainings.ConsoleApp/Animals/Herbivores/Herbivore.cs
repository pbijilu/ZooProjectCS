using System;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    abstract class Herbivore : Animal
    {
        public Herbivore(string name, int age, Sex sex, int grassQuantity) : base(name, age, sex)
        {
            this.GrassQuantity = grassQuantity;
        }

        public int GrassQuantity { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Trying to eat...");
            if (GrassQuantity > 0)
            {
                Console.WriteLine("Success! Had some tasty grass!");
                GrassQuantity--;
            }
            else
            {
                Console.WriteLine("No grass bales available.");
            }
        }

        public override string ToString()
        {
            string s = base.ToString() + $" I have {GrassQuantity} grass bales.";
            return s;
        }
    }
}
