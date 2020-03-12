using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Enums;

namespace Trainings.ConsoleApp.Zones
{
    class Zone
    {
        public Zone(string id, GroundType ground)
        {
            Id = id;
            Ground = ground;
            Animals = new Animal[4];
   
        }

        public GroundType Ground { get; }

        public Animal[] Animals { get; }

        public string Id { get; }

        public override string ToString()
        {
            string s = $"This is a {Ground} zone.";
            return s;
        }
    }
}
