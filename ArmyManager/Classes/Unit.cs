using ArmyManager.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using static ArmyManager.Data.DiceSizes;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.SkillLevel;
using static ArmyManager.Data.UnitTypes;

namespace ArmyManager.Classes
{
    public partial class Unit
    {
        private int unitSize;

        //Properties
        public string Name { get; private set; }
        public Race Species { get; private set; }
        public Level Expireince { get; private set; }
        public EquipmentLevel Equipment { get; private set; }
        public UnitType Type { get; private set; }
        public List<Trait> Traits;
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int Morale { get; set; }
        public int Cost { get; private set; }
        public Dice DiceSize { get; private set; }

        public Unit(string name, Race species, Level expireince, EquipmentLevel equipmentLevel,
            UnitType unitType, List<Trait> unitTraits, Dice size)
        {
            Name = name;
            Species = species;
            Expireince = expireince;
            Equipment = equipmentLevel;
            Type = unitType;
            Traits = unitTraits;
            DiceSize = size;
            unitSize = (int)size;

            Traits.AddRange(Species.RaceTraits);

            SetViatalStatistics();
        }

        private void SetViatalStatistics()
        {
            //Reset to defaults
            Attack = 0;
            Defense = 10;
            Power = 0;
            Toughness = 10;
            Morale = 0;

            //Add race bonuses
            Attack += Species.Attack;
            Defense += Species.Defence;
            Power += Species.Power;
            Toughness += Species.Toughness;
            Morale += Species.Morale;

            AddSkillBonus(this);
            AddEquipmentBonus(this);
            AddTypeBonus(this);
        }

        public void Save()
        {
            using (var file = new StreamWriter($"{ConfigurationManager.AppSettings["UnitFilePath"]}{Name}", false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this);
            }
        }
    }
}