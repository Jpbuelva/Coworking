using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts
{
    public interface ICoworkingDBContext
    {
        DbSet<Admin> Admin { get; set; }
        DbSet<Booking> Booking { get; set; }
        DbSet<Office> Office { get; set; }
        DbSet<OfficesToRoom> OfficesToRoom { get; set; }
        DbSet<Room> Room { get; set; }
        DbSet<RoomToService> RoomToService { get; set; }
        DbSet<Service> Service { get; set; }
        DbSet<User> User { get; set; }

    }
}
