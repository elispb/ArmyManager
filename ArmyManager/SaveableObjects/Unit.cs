using ArmyManager.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using static ArmyManager.Data.DiceSizes;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.SkillLevel;
using static ArmyManager.Data.UnitTypes;

namespace ArmyManager.SaveableObjects
{
    public partial class Unit
    {
        //Properties
        public int UnitId { get; set; }
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
        public int CostMultiplier {get; private set;}
        public Dice DiceSize { get; private set; }


        private int UnitSize { get; set; }
        private int DaysSinceWounded { get; set; }
        private int FightsWonSinceLevelUp { get; set; }

        public Unit() { }
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
            UnitSize = (int)size;

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

        public void RecoverOverTime(int daysRecovery)
        {
            if (UnitSize < (int)DiceSize)
            {
                if (DaysSinceWounded == 0)
                {
                    UnitSize++;
                    DaysSinceWounded++;
                    daysRecovery--;
                }
                while (daysRecovery >= 0 && daysRecovery - 7 >= 0 && UnitSize < (int)DiceSize)
                {
                    UnitSize++;
                    DaysSinceWounded += 7;
                    daysRecovery = daysRecovery - 7;
                }
            }
        }

        public void TakeWound(int damage)
        {
            UnitSize -= damage;
            DaysSinceWounded = 0;
        }

        public void PostBattle()
        {
            if (UnitSize > 0)
            {
                UnitSize = 0;
                Cost = 0;
            }

            if (UnitSize < (int)DiceSize)
            {
                var oldSize = DiceSize;
                while ((int)DiceSize - UnitSize >= 2 && DiceSize > Dice.d4)
                {
                    DiceSize = DiceSize - 2;
                }

                if (oldSize > DiceSize)
                {
                    Cost = ApplyDiceSizeCoustMultiplier(ConvertToD6Cost(Cost, oldSize), DiceSize);
                }
            }
        }
    }
}