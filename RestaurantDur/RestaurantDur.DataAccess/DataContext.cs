using Microsoft.EntityFrameworkCore;
using RestaurantDur.DataAccess.Mappings;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }

        public DbSet<Component> Components { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealComponents> MealComponents { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<TypeOfWork> TypesOfWork { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ComponentMapping());
            builder.ApplyConfiguration(new MealMapping());
            builder.ApplyConfiguration(new MealComponentsMapping());
            builder.ApplyConfiguration(new OrderMapping());
            builder.ApplyConfiguration(new OrderItemMapping());
            builder.ApplyConfiguration(new OrderStatusMapping());
            builder.ApplyConfiguration(new TableMapping());
            builder.ApplyConfiguration(new TableStatusMapping());
            builder.ApplyConfiguration(new TypeOfWorkMapping());
            builder.ApplyConfiguration(new WorkerMapping());
        }
    }
}
