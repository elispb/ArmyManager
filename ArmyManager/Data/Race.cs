using System.Collections.Generic;

namespace ArmyManager.Data
{
    public class Race
    {
        public string Name { get; set; }
        public List<Traits> RaceTraits { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int Morale { get; set; }

        public Race(string name)
        {
            Name = name;
            RaceTraits = new List<Traits>();
        }
    }
}