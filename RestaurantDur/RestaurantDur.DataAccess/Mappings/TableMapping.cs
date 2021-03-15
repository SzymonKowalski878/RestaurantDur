using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class TableMapping:IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .HasOne(m => m.Worker)
                .WithMany()
                .HasForeignKey(m => m.WorkerId);

            builder
                .HasOne(m => m.TableStatus)
                .WithMany()
                .HasForeignKey(m => m.TableStatusId);
        }
    }
}
