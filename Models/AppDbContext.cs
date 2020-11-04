using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YClient_htinoco2.Models
{
    public class AppDbContext: DbContext
    {
        public virtual DbSet<Valoresc> Valorestab { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
