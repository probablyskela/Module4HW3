using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.Models
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(e => e.TitleId);
            builder.Property(e => e.TitleId).IsRequired().HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        }
    }
}
