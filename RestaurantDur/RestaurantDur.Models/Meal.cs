using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class Meal:BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
