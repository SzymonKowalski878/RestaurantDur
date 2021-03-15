using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class OrderItem:BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual int ComponentId { get; set; }
        public virtual Component Component { get; set; }
    }
}
