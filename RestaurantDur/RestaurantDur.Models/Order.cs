using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class Order:BaseModel
    {
        public int Discount { get; set; }
        public DateTime DateOFAcceptance { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual int TableId { get; set; }
        public virtual Table Tables { get; set; }
        public virtual int OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }


    }
}
