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
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> s)
        {
            s.HasKey(s => s.ID);

            s.Property("FName")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .HasDefaultValue("None")
             .IsRequired();

            s.Property("LName")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .HasDefaultValue("None")
             .IsRequired();

            s.Property("Address")
             .HasColumnType("nvarchar")
             .HasMaxLength(200);

            s.Property("Age")
              .HasColumnType("int");

        }
               
    }
}
