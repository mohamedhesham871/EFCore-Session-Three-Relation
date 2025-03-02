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
    internal class Ins_Config : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> i)
        {
            i.HasKey(i=>i.ID);

            i.Property(i=>i.Name)
             .HasColumnType("nvarchar")
             .IsRequired()
             .HasMaxLength(50);

            i.Property(i => i.Salary)
            .HasColumnType("DECIMAL")
            .IsRequired();

            i.Property(i => i.Bouns)
            .HasColumnType("DECIMAL")
            .IsRequired(false);

            i.Property(i => i.Address)
            .HasColumnType("nvarchar")
            .IsRequired(false)
            .HasMaxLength(100);

            i.Property(i => i.HoureRate)
            .HasColumnType("int")
            .IsRequired(false);

        }
    }
}
