using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.Models
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).IsRequired().HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).IsRequired().HasColumnName("Rate");
            builder.Property(e => e.StartedDate).IsRequired().HasColumnName("StartedDate");
            builder.Property(e => e.EmployeeId).IsRequired().HasColumnName("EmployeeId");
            builder.Property(e => e.ProjectId).IsRequired().HasColumnName("ProjectId");

            builder.HasOne(e => e.Employee)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(o => o.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(o => o.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
