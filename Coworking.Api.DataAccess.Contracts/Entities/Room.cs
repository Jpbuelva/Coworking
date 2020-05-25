using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class Room
    {
        public Room()
        {
            OfficesToRoom = new HashSet<OfficesToRoom>();
            RoomToService = new HashSet<RoomToService>();
        }

        public int RoomId { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }

        public virtual ICollection<OfficesToRoom> OfficesToRoom { get; set; }
        public virtual ICollection<RoomToService> RoomToService { get; set; }
    }
}
