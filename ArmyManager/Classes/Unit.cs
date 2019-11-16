using ArmyManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ArmyManager.Data.DiceSizes;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.Race;
using static ArmyManager.Data.SkillLevel;
using static ArmyManager.Data.UnitTypes;

namespace ArmyManager.Classes
{
    public class Unit
    {
        private int unitSize;

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
        public int Cost { get; private set; }
        public Dice DiceSize { get; private set; }

        public Unit(Race species, Level expireince, EquipmentLevel equipmentLevel,
            UnitType unitType, List<UnitTrait> unitTraits, Dice size)
        {
            Species = species;
            Expireince = expireince;
            Equipment = equipmentLevel;
            Type = unitType;
            Traits = unitTraits;
            DiceSize = size;
            unitSize = (int)size;

            Traits.AddRange(Species.RaceTraits);
        }

        private void SetViatalStatistics()
        {
            //Reset to defaults
            Attack = 0;
            Defence = 10;
            Power = 0;
            Toughnes = 10;
            Morale = 0;

            //Add race bonuses
            Attack += Species.Attack;
            Defence += Species.Defence;
            Power += Species.Power;
            Toughnes += Species.Toughness;
            Morale += Species.Morale;
        }
    }
}