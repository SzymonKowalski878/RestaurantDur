using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class Table:BaseModel
    {
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public virtual int TableStatusId { get; set; }
        public virtual TableStatus TableStatus { get; set; }
        public virtual int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
