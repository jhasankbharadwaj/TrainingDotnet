using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEntitycore.Models;

namespace MvcEntitycore.Data
{
    public class MvcEntitycoreContext : DbContext
    {
        public MvcEntitycoreContext (DbContextOptions<MvcEntitycoreContext> options)
            : base(options)
        {
            Database.EnsureCreated();

        }

        public DbSet<MvcEntitycore.Models.Employee> Employee { get; set; } = default!;

    }
}
