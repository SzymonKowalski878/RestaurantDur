using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class Component:BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
