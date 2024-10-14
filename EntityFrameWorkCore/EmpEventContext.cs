using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCore
{
    internal class EmpEventContext:DbContext
    {
      
        public EmpEventContext(DbContextOptions<EmpEventContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
