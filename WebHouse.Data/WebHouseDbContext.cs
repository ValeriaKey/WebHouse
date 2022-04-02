using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHouse.Core.Domain;

namespace WebHouse.Data
{
    public class WebHouseDbContext : DbContext
    {
        public WebHouseDbContext(DbContextOptions<WebHouseDbContext> options)
            : base(options) { }

        public DbSet<House> House { get; set; }
    }
}
