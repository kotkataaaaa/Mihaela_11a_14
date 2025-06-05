using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihaela_11a_14
{
    public class DishTypeConnection
    {
        private RestaurantContext restaurantContext = new RestaurantContext(); 
        public List<DishType> GetAllDishTypes()
       {
           return restaurantContext.DishTypes.ToList();
       }

         public string GetDishTypeById(int id)
         {
            return restaurantContext.DishTypes.Find(id).Name;
         }
    }
}
