using Mihaela_11a_14.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihaela_11a_14.Controlers
{
    public class DishControler
    {
        private RestaurantContext restaurantContext = new RestaurantContext(); 

       public Dish Get(int id)
        {
           Dish findedDish = restaurantContext.Dishes.Find(id);
           if (findedDish !=null)
           {
              restaurantContext.Entry(findedDish).Reference(x => x.DishTypes).Load();
           }
            return findedDish;
        }

        public List<Dish> GetAll()
         {
             return restaurantContext.Dishes.Include("DishType").ToList();
         }

        public void Create(Dish dish) 
        {
           restaurantContext.Dishes.Add(dish);
           restaurantContext.SaveChanges();
        }

         public void Update(int id, Dish dish)
          {
            Dish findedDish = restaurantContext.Dishes.Find(id);
            if (findedDish== null) 
            {  
                return;
            }
            findedDish.Name = dish.Name;
            findedDish.Description = dish.Description;
            findedDish.Price = dish.Price;
            findedDish.Weight = dish.Weight;
            findedDish.DishTypeId = dish.DishTypeId;
            restaurantContext.SaveChanges();
          }

         public void Delete(int id)
          {
            Dish findedDish = restaurantContext.Dishes.Find(id);
            restaurantContext.Dishes.Remove(findedDish);
            restaurantContext.SaveChanges();
          }
    }
}
