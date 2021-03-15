using RestaurantDur.DataAccess.RepositoryInterfaces;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Repositories
{
    public class TableRepository:Repository<Table>,ITableRepository
    {
        public TableRepository(Lazy<DataContext> dataContext)
            : base(dataContext)
        {

        }
    }
}
