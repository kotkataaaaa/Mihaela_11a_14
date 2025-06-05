using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihaela_11a_14
{
    public class DishType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Dish> Dishes { get; set; }
    }
}
