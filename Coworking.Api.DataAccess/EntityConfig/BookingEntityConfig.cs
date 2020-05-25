using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class BookingEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(e => e.IdBooking);

            builder.Property(e => e.IdBooking).ValueGeneratedNever();

            builder.Property(e => e.BookinDate).HasColumnType("date");

            builder.Property(e => e.Date).HasColumnType("date");

            builder.Property(e => e.UserId).HasColumnName("userId");

            builder.HasOne(d => d.Office)
                .WithMany(p => p.Booking)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_Booking_Office");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Booking)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Booking_User");
        }
    }
}
