using System;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Animals.Herbivores
{
    abstract class Herbivore : Animal
    {
        public Herbivore() : base()
        {
            Console.WriteLine("Do you want to give it some grass? Please enter the grass quantity ('0' for no meat)");
            GrassQuantity = Convert.ToInt32(Console.ReadLine());
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
