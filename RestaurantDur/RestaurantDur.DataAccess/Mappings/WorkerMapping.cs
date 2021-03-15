using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class WorkerMapping:IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .HasOne(m => m.TypeOfWork)
                .WithMany()
                .HasForeignKey(m => m.TypeOfWorkId);

        }
    }
}
