using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Animals;

namespace Trainings.ConsoleApp.Creators
{
    abstract class Creator
    {
        public abstract Animal Create();
    }
}
