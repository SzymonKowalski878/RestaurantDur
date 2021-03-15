using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.RepositoryInterfaces
{
    public interface IRepository<T> where T:BaseModel
    {
        void Add(T model);
        void SaveChanges();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
