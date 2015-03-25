namespace Harjoitustyo2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Harjoitustyo2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Harjoitustyo2.Models.Harjoitustyo2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Harjoitustyo2.Models.Harjoitustyo2Context context)
        {
            context.Owners.AddOrUpdate(x => x.Id,
                new Owner() { Id = 1, FirstName = "Sanna", LastName = "Suutari" },
                new Owner() { Id = 2, FirstName = "Markku", LastName = "Sillanpää" },
                new Owner() { Id = 3, FirstName = "Tarja", LastName = "Heikkilä" }
                );

            context.Cars.AddOrUpdate(x => x.Id,
                new Car()
                {
                    Id = 1,
                    Model = "Honda CR-V",
                    Year = 2000,
                    Price = 2200.00M,
                    OwnerId = 1,
                },
                new Car()
                {
                    Id = 2,
                    Model = "Subaru Outback",
                    Year = 1999,
                    Price = 3000.00M,
                    OwnerId = 2,
                },
                new Car()
                {
                    Id = 3,
                    Model = "Ford F-150",
                    Year = 1989,
                    Price = 2200.00M,
                    OwnerId = 3,
                },
                new Car()
                {
                    Id = 4,
                    Model = "Mazda CX-5",
                    Year = 2012,
                    Price = 27600.00M,
                    OwnerId = 1,
                }

                );
        }
    }
}
