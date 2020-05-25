using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class User
    {
        public User()
        {
            Booking = new HashSet<Booking>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public DateTime? CrateDate { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
