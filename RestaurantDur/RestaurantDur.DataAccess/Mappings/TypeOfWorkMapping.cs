using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class TypeOfWorkMapping:IEntityTypeConfiguration<TypeOfWork>
    {
        public void Configure(EntityTypeBuilder<TypeOfWork> builder)
        {
            builder
                .HasKey(m => m.Id);
        }
    }
}
