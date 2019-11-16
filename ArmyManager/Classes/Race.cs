using ArmyManager.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace ArmyManager.Classes
{
    public class Race
    {
        public string Name { get; set; }
        public List<Trait> RaceTraits { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int Morale { get; set; }

        public Race(string name)
        {
            Name = name;
            RaceTraits = new List<Trait>();
        }
    }
}