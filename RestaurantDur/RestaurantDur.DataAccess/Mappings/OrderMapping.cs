using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class OrderMapping:IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .HasOne(m => m.Tables)
                .WithMany()
                .HasForeignKey(m => m.TableId);

            builder
                .HasOne(m => m.OrderStatus)
                .WithMany()
                .HasForeignKey(m => m.OrderStatusId);

            builder
                .HasOne(m => m.Worker)
                .WithMany()
                .HasForeignKey(m => m.WorkerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
