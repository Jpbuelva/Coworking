using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class RoomToService
    {
        public int? ServiceId { get; set; }
        public int? RoomId { get; set; }
        public int RoomToServiceId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Service Service { get; set; }
    }
}
