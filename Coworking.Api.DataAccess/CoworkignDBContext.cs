using Coworking.Api.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess
{
    public class CoworkignDBContext : DbContext , ICoworkingDBContext
    {
        public CoworkignDBContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



        }
    }
}
