using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07SportsStore.Data.Mapping
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            //table
            builder.ToTable("City");
            //keys
            builder.HasKey(t => t.Postalcode);
            //properties
            builder.Property(t => t.Postalcode).HasMaxLength(5);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            
        }
    }
}
