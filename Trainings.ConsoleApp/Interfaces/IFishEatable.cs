using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainings.ConsoleApp.Interfaces
{
    interface IFishEatable
    {
        int FishQuantity { get; set; }

        void EatFish();
    }
}
