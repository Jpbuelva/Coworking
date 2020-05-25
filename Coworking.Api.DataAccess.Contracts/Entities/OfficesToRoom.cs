using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class OfficesToRoom
    {
        public int? OfficeId { get; set; }
        public int? RoomId { get; set; }
        public int OfficesToRoomId { get; set; }

        public virtual Office Office { get; set; }
        public virtual Room Room { get; set; }
    }
}
