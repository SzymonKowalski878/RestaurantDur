using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.Models
{
    public class Worker : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual int TypeOfWorkId { get; set; }
        public virtual TypeOfWork TypeOfWork { get; set; }
    }
}
