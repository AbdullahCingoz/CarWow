namespace CarWow.Migrations
{
    using CarWow.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarWow.Models.CarWowDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(CarWow.Models.CarWowDb context)
        {
            context.ManagerTypes.AddOrUpdate(s => s.ID, new ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(s => s.ID, new ManagerType() { ID = 2, Name = "Moderatör" });
            context.Managers.AddOrUpdate(s => s.ID, new Manager() { ID = 1, Name = "Abdullah", Surname = "Cingöz", Mail = "abdullahcn03@gmail.com", Password = "1234", ManagerType_ID = 1, ProfileImage = "none.png", Status = true, CreationDate = Convert.ToDateTime("02/07/2022") });
        }
    }
}
