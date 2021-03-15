using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class TableStatusMapping:IEntityTypeConfiguration<TableStatus>
    {
        public void Configure(EntityTypeBuilder<TableStatus> builder)
        {
            builder
                .HasKey(m => m.Id);
        }
    }
}
