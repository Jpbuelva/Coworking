using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class OfficeEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Office> builder)
        {
            builder.Property(e => e.OfficeId).ValueGeneratedNever();

            builder.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PriceWorkSpaceDaily).HasColumnType("decimal(18, 0)");

            builder.Property(e => e.PriceWorkSpaceMonthly).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IdAdminNavigation)
                .WithMany(p => p.Office)
                .HasForeignKey(d => d.IdAdmin)
                .HasConstraintName("FK_Office_Admin");
        }
    }
}
