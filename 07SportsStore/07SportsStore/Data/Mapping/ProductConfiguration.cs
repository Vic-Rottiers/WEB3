using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07SportsStore.Data.Mapping
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //table
            builder.ToTable("Product");
            //keys - default is ok
            //properties
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
        }
    }
}
