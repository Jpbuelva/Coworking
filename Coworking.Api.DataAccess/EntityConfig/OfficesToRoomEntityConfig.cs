using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class OfficesToRoomEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<OfficesToRoom> builder)
        {
            builder.Property(e => e.OfficesToRoomId).ValueGeneratedNever();

            builder.HasOne(d => d.Office)
                .WithMany(p => p.OfficesToRoom)
                .HasForeignKey(d => d.OfficeId)
                .HasConstraintName("FK_OfficesToRoom_Office");

            builder.HasOne(d => d.Room)
                .WithMany(p => p.OfficesToRoom)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_OfficesToRoom_Room");
        }
    }
}
