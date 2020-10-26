using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07SportsStore.Data.Mapping
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //table
            //keys
            //OKOK
            //properties
            builder.HasOne(t => t.City).WithMany().IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
