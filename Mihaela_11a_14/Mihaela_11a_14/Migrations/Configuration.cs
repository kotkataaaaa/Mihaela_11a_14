namespace Mihaela_11a_14.Migrations.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Mihaela_11a_14.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantContext>
    {
        public Configuration()

        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestaurantContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
