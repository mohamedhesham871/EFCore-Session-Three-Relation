using EFCore_Session_Three_Relation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Configuration
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(c => c.ID);

            C.Property(c=>c.Name)
             .HasColumnType("nvarchar")
             .HasMaxLength(100)
             .IsRequired(true);

            C.Property(c=>c.Description)
             .HasColumnType("nvarchar")
             .HasMaxLength(250)
             .IsRequired(false);

            C.Property(c => c.Duration).HasColumnType("int");
        }

    }
}
