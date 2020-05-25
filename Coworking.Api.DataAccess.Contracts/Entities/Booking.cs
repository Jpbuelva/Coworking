using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class Booking
    {
        public int IdBooking { get; set; }
        public DateTime? BookinDate { get; set; }
        public DateTime? Date { get; set; }
        public bool? RentWoorkSapce { get; set; }
        public int Roomid { get; set; }
        public int? UserId { get; set; }
        public int? OfficeId { get; set; }

        public virtual Office Office { get; set; }
        public virtual User User { get; set; }
    }
}
