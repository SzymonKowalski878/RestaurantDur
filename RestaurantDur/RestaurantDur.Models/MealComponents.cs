using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class MealComponents:BaseModel
    {
        public virtual int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual int ComponentId { get; set; }
        public virtual Component Component { get; set; }
    }
}
