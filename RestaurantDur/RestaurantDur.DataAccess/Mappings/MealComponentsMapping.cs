using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDur.DataAccess.Mappings
{
    public class MealComponentsMapping : IEntityTypeConfiguration<MealComponents>
    {
        public void Configure(EntityTypeBuilder<MealComponents> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .HasOne(m => m.Meal)
                .WithMany()
                .HasForeignKey(m => m.MealId);

            builder
                .HasOne(m => m.Component)
                .WithMany()
                .HasForeignKey(m => m.ComponentId);
        }
    }
}
