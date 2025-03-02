using EFCore_Session_Three_Relation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_Three_Relation.Configuration
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.HasKey(d=>d.ID);

            d.Property(d=>d.Name).HasColumnType("varchar").HasDefaultValue("None").IsRequired(true).HasMaxLength(100);

            d.Property(d => d.HiringDate).HasColumnType("date");
        }
    }
}
