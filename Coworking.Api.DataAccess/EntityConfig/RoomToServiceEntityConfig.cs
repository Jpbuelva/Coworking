using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class RoomToServiceEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<RoomToService> builder)
        {
            builder.Property(e => e.RoomToServiceId).ValueGeneratedNever();

            builder.HasOne(d => d.Room)
                .WithMany(p => p.RoomToService)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_RoomToService_Room");

            builder.HasOne(d => d.Service)
                .WithMany(p => p.RoomToService)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK_RoomToService_Service");
        }
    }
}
