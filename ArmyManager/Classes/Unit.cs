using ArmyManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.Races;
using static ArmyManager.Data.SkillLevel;
using static ArmyManager.Data.UnitTypes;

namespace ArmyManager.Classes
{
    public class Unit
    {
        //Properties
        public Race Species { get; private set; }
        public Level Expireince { get; private set; }
        public EquipmentLevel Equipment { get; private set; }
        public UnitType Type { get; private set; }
        public List<UnitTrait> Traits;
        public int Attack { get; private set; }
        public int Defence { get; private set; }
        public int Power { get; private set; }
        public int Toughnes { get; private set; }
        public int Morale { get; private set; }
        public int Size { get; private set; }
        public int Cost { get; private set; }
    }
}