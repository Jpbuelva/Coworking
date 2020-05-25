using System;
using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Coworking.Api.DataAccess
{
    public partial class CoworkingContext : DbContext, ICoworkingDBContext
    {
        public CoworkingContext()
        {
        }

        public CoworkingContext(DbContextOptions<CoworkingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<OfficesToRoom> OfficesToRoom { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomToService> RoomToService { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<User> User { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<Admin>());
            BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<Booking>());
            OfficeEntityConfig.SetEntityBuilder(modelBuilder.Entity<Office>());
            OfficesToRoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<OfficesToRoom>());
            RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<Room>());
            RoomToServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomToService>());
            ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<Service>());
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<User>());

        }   
    }
}
