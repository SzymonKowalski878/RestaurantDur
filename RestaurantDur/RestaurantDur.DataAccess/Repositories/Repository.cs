using RestaurantDur.DataAccess.RepositoryInterfaces;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantDur.DataAccess.Repositories
{
    public class Repository<T>:IRepository<T> where T:BaseModel
    {
        private readonly Lazy<DataContext> _dataContext;
        protected DataContext DataContext => _dataContext.Value;

        public Repository(Lazy<DataContext> dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual void Add(T model)
        {
            DataContext.Set<T>().Add(model);
        }

        public virtual void SaveChanges()
        {
            DataContext.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DataContext.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return DataContext.Set<T>().FirstOrDefault(m => m.Id == id);
        }
    }
}
