using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArmyManager.Data
{
    public class Race
    {
        public string Name { get; private set; }
        public List<UnitTrait> RaceTraits { get; private set; }
        public int Attack { get; private set; }
        public int Defence { get; private set; }
        public int Power { get; private set; }
        public int Toughness { get; private set; }
        public int Morale { get; private set; }

        public Race(string name)
        {
            Name = name;
        }
    }
}