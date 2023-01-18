using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.Models
{
    internal class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(e => e.OfficeId);
            builder.Property(e => e.OfficeId).IsRequired().HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(e => e.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
            builder.Property(e => e.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);
        }
    }
}
