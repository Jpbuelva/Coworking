using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class Service
    {
        public Service()
        {
            RoomToService = new HashSet<RoomToService>();
        }

        public int ServiceId { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<RoomToService> RoomToService { get; set; }
    }
}
