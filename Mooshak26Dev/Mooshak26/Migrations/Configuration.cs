namespace Mooshak26.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Mooshak26.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mooshak26.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            ApplicationDbContext _db = new ApplicationDbContext();
            _db.Users.AddOrUpdate(p => p.userName,
            new Models.Entities.User
            {
                userName = "Student",
                kennitala = 0000000000,
                email = "student@student.com",
                role = "Student"
            },
            new Models.Entities.User
            {
                userName = "Teacher",
                kennitala = 1111111111,
                email = "teacher@teacher.com",
                role = "Teacher"
            }
      
        );
        }
    }
}
