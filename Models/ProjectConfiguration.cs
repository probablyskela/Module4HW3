using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.Models
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(e => e.ProjectId);
            builder.Property(e => e.ProjectId).IsRequired().HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            builder.Property(e => e.Budget).IsRequired().HasColumnName("Budget");
            builder.Property(e => e.StartedDate).IsRequired().HasColumnName("StartedDate");
        }
    }
}
