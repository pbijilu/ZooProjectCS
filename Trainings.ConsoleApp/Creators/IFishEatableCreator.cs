using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Creators
{
    interface IFishEatableCreator
    {
        Animal Create(string name, int age, Sex sex, int foodQuantity, int fishQuantity);
    }
}
