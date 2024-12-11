using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_DI_Project.Models;

namespace MVC_DI_Project.Data
{
    public class MVC_DI_ProjectContext : DbContext
    {
        public MVC_DI_ProjectContext (DbContextOptions<MVC_DI_ProjectContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MVC_DI_Project.Models.Computer> Computer { get; set; } = default!;
    }
}
