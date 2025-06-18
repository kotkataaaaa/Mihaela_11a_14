<<<<<<< HEAD
﻿namespace Mihaela_11a_14.Migrations
=======
﻿namespace Mihaela_11a_14.Migrations.Data
>>>>>>> 636cc60a0e45fddf1ace4a8d21f183a159c1fe24
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
<<<<<<< HEAD

    internal sealed class Configuration : DbMigrationsConfiguration<Mihaela_11a_14.RestaurantContext>
    {
        public Configuration()
=======
    using Mihaela_11a_14.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantContext>
    {
        public Configuration()

>>>>>>> 636cc60a0e45fddf1ace4a8d21f183a159c1fe24
        {
            AutomaticMigrationsEnabled = false;
        }

<<<<<<< HEAD
        protected override void Seed(Mihaela_11a_14.RestaurantContext context)
=======
        protected override void Seed(RestaurantContext context)
>>>>>>> 636cc60a0e45fddf1ace4a8d21f183a159c1fe24
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
