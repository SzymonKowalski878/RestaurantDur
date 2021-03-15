using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class OrderItemMapping:IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .HasOne(m => m.Component)
                .WithMany()
                .HasForeignKey(m => m.ComponentId);

            builder
                .HasOne(m => m.Meal)
                .WithMany()
                .HasForeignKey(m => m.MealId);
        }
    }
}
