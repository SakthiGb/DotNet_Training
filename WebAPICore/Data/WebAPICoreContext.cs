using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPICore.Model;

namespace WebAPICore.Data
{
    public class WebAPICoreContext : DbContext
    {
        public WebAPICoreContext (DbContextOptions<WebAPICoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPICore.Model.Product> Product { get; set; } = default!;

        public DbSet<WebAPICore.Model.Category> Category { get; set; } = default!;
    }
}
