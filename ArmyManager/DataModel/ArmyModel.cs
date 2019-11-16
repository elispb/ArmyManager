namespace ArmyManager.DataModel
{
    using ArmyManager.Classes;
    using System.Data.Entity;

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
                context.Units.Add(unit);
                foreach (var trait in unit.Traits)
                {
                    AddTrait(trait);
                }
                context.SaveChanges();
            }
        }
        public static void AddTrait(Trait trait)
        {
            using (var context = new ArmyContext())
            {
                context.Traits.Add(trait);
            }
        }
    }
}
