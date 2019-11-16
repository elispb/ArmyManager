using ArmyManager.Data;
using System.Collections.Generic;
using System.Data.Entity;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.SkillLevel;
using static ArmyManager.Data.UnitTypes;

namespace ArmyManager.DataController
{
    public class ArmyContext : DbContext
    {
        public ArmyContext() : base("ArmyContext") { }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Trait> Tratis { get; set; }
        public DbSet<Race> Races { get; set; }

        private static void AddUnit(string name, Race species, Level expireince, EquipmentLevel equipmentLevel,
            UnitType unitType, List<Trait> unitTraits, int size)
        {
            using (var context = new ArmyContext())
            {
                var unit = new Unit
                {
                    Name = name,
                    Race = species.Id,
                    XpLevel = (int)expireince,
                    Equipment = (int)equipmentLevel,
                    UnitType = (int)unitType,
                    Traits = unitTraits,
                    Size = size,
                };

                context.Units.Add(unit);
                context.SaveChanges();
            }
        }
    }
}