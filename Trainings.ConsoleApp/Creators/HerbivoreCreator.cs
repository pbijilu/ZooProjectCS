using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainings.ConsoleApp.Creators
{
    class AnimalCreator
    {
        Console.WriteLine("Enter animal's name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter animal's age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select animal's sex: ('1' for male, '2' for female)");
            Sex = (Sex) Convert.ToInt32(Console.ReadLine());
    }
}
