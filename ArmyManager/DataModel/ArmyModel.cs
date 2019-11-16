namespace ArmyManager.DataModel
{
    using ArmyManager.Classes;
    using System.Data.Entity;

    public class ArmyModel : DbContext
    {
        // Your context has been configured to use a 'ArmyModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ArmyManager.DataModel.ArmyModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ArmyModel' 
        // connection string in the application configuration file.
        public ArmyModel()
            : base("name=ArmyModel")
        {
        }
        public class ArmyContext : DbContext
        {
            public ArmyContext() : base("ArmyContext") { }
            public DbSet<Unit> Students { get; set; }
            public DbSet<Trait> Enrollments { get; set; }
            public DbSet<Race> Courses { get; set; }
        }
        }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}