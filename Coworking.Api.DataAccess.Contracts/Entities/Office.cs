using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class Office
    {
        public Office()
        {
            Booking = new HashSet<Booking>();
            OfficesToRoom = new HashSet<OfficesToRoom>();
        }

        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool? Active { get; set; }
        public bool? HasIndividualWorkSpace { get; set; }
        public int? NumberWorkSpace { get; set; }
        public decimal? PriceWorkSpaceDaily { get; set; }
        public decimal? PriceWorkSpaceMonthly { get; set; }
        public int? IdAdmin { get; set; }

        public virtual Admin IdAdminNavigation { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<OfficesToRoom> OfficesToRoom { get; set; }
    }
}
