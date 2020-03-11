﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainings.ConsoleApp.Animals;
using Trainings.ConsoleApp.Animals.Herbivores;
using Trainings.ConsoleApp.Animals.Predators;
using Trainings.ConsoleApp.Enums;
using Trainings.ConsoleApp.Zones;

namespace Trainings.ConsoleApp.Creators
{
    class HippopotamusCreator : Creator
    {
        Zone zone;

        public HippopotamusCreator(Zone zone)
        {
            this.zone = zone;
        }
        public override Animal Create()
        {
            if (zone.Ground != GroundType.Water)
            {
                Console.WriteLine("This animal can't live here.");
                return null;
            }

            for (int i = 0; i < zone.Animals.Length; i++)
            {
                if (zone.Animals[i] is Predator)
                {
                    Console.WriteLine("Predators can't live with herbivores.");
                    return null;
                }
            }
            return new Hippopotamus();
        }
    }
}
