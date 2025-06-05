using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Mihaela_11a_14
{
    public class RestaurantContext: DbContext
    {
        public RestaurantContext() : base("RestaurantContext")
        {

        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishType> DishTypes { get; set; }

    }
}
