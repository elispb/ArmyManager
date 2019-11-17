using System.Collections.Generic;

namespace ArmyManager.SaveableObjects
{
    public class Race
    {
        public int RaceId { get; set; }
        public string Name { get; set; }
        public List<Trait> RaceTraits { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int Morale { get; set; }

        public Race()
        {
            RaceTraits = new List<Trait>();
        }
        public Race(string name)
        {
            Name = name;
            RaceTraits = new List<Trait>();
        }
    }
}