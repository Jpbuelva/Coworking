using System;
using System.Collections.Generic;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public partial class Admin
    {
        public Admin()
        {
            Office = new HashSet<Office>();
        }

        public int IdAdmin { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Office> Office { get; set; }
    }
}
