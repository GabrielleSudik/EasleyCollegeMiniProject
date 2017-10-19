//you have to add the following line here:
using EasleyCollegeMiniProject.Models; //huh, we actually don't need this.
namespace EasleyCollegeMiniProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EasleyCollegeMiniProject.Models.EasleyCollegeMiniProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EasleyCollegeMiniProject.Models.EasleyCollegeMiniProjectContext";
        }

        protected override void Seed(EasleyCollegeMiniProject.Models.EasleyCollegeMiniProjectContext context)
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

            //that stuff above was already here, in green comment.
            //we can use it to let us know what to type if we want to seed data!
            //for us, it would be : context.Students.AddOrUpdate...
            // ... new Student {Name = "Pete", DOB = new DateTime(1974,8,8), onCampus = true, etc...}
            //then context.Courses.AddOrUpdate...
            //make sure you do it like above (you shortcutted in your notes)

            //FINAL STEP! Update-Database in Nuget
        }
    }
}
