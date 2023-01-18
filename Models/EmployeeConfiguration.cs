using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.Models
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeId).IsRequired().HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired().HasColumnName("HiredDate");
            builder.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth");
            builder.Property(e => e.OfficeId).IsRequired().HasColumnName("OfficeId");
            builder.Property(e => e.TitleId).IsRequired().HasColumnName("TitleId");

            builder.HasOne(e => e.Office)
                .WithMany(p => p.Employees)
                .HasForeignKey(o => o.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Title)
                .WithMany(p => p.Employees)
                .HasForeignKey(o => o.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
