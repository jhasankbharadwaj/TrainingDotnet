using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebappProject.Models;

namespace WebappProject.Data
{
    public class WebappProjectContext : DbContext
    {
        public WebappProjectContext (DbContextOptions<WebappProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebappProject.Models.CustEntity> CustEntitys { get; set; } = default!;

    }
}
