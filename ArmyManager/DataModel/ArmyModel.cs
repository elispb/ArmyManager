namespace ArmyManager.DataModel
{
    using ArmyManager.SaveableObjects;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ArmyContext : DbContext
    {
        public ArmyContext() : base("ArmyContext") { }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<Race> Races { get; set; }


        public static void AddUnit(Unit unit)
        {
            using (var context = new ArmyContext())
            {
                if (unit.UnitId > 0)
                {
                    UpdateUnit(unit);
                }
                else
                {
                    context.Units.Add(unit);
                    context.SaveChanges();
                }

                AddRace(unit.Species);

                foreach (var trait in unit.Traits)
                {
                    AddTrait(trait);
                }
            }
        }

        public static void UpdateUnit(Unit unit)
        {
            using (var context = new ArmyContext())
            {
                if (unit.UnitId > 0)
                {
                    var unitToUpdate = (from d in context.Units where d.UnitId == unit.UnitId select d).Single();

                    unitToUpdate = unit;
                    context.SaveChanges();
                }
                else
                {
                    AddUnit(unit);
                }
            }
        }

        public static Unit GetUnitById(int id)
        {
            using (var context = new ArmyContext())
            {
                return (from u in context.Units where u.UnitId == id select u).Single();
            }
        }

        public static IEnumerable<Unit> GetUnits()
        {
            using (var context = new ArmyContext())
            {
                return context.Units.ToList();
            }
        }

        public static void AddTrait(Trait trait)
        {
            using (var context = new ArmyContext())
            {
                if (trait.TraitId > 0)
                {
                    UpdateTrait(trait);
                }
                else
                {
                    context.Traits.Add(trait);
                }
                context.SaveChanges();
            }
        }

        public static void UpdateTrait(Trait trait)
        {
            using (var context = new ArmyContext())
            {
                if (trait.TraitId > 0)
                {
                    var traitToUpdate = (from d in context.Traits where d.TraitId == trait.TraitId select d).Single();

                    traitToUpdate = trait;
                    context.SaveChanges();
                }
                else
                {
                    AddTrait(trait);
                }
            }
        }

        public static Trait GetTraitById(int id)
        {
            using (var context = new ArmyContext())
            {
                return (from t in context.Traits where t.TraitId == id select t).Single();
            }
        }

        public static IEnumerable<Trait> GetTraits()
        {
            using (var context = new ArmyContext())
            {
                return context.Traits.ToList();
            }
        }

        public static void AddRace(Race race)
        {
            using (var context = new ArmyContext())
            {
                if (race.RaceId > 0)
                {
                    UpdateRace(race);
                }
                else
                {
                    context.Races.Add(race);
                }
                foreach (var trait in race.RaceTraits)
                {
                    AddTrait(trait);
                }
                context.SaveChanges();
            }
        }

        public static void UpdateRace(Race race)
        {
            using (var context = new ArmyContext())
            {
                if (race.RaceId > 0)
                {
                    var raceToUpdate = (from d in context.Races where d.RaceId == race.RaceId select d).Single();

                    raceToUpdate = race;
                    context.SaveChanges();
                }
                else
                {
                    AddRace(race);
                }
            }
        }

        public static Race GetRaceById(int id)
        {
            using (var context = new ArmyContext())
            {
                return (from r in context.Races where r.RaceId == id select r).Single();
            }
        }

        public static IEnumerable<Race> GetRaces()
        {
            using (var context = new ArmyContext())
            {
                return context.Races.ToList();
            }
        }
    }
}
