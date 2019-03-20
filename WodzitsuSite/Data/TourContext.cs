using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;

namespace WodzitsuSite.Data
{
    public class TourContext : IdentityDbContext<Czlopok>
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options) { }

        public DbSet<Tour> Tours { get; set; }

    }
}
