using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using spjeniscat.Models;

namespace spjeniscat.Data
{
    public class AppDbContext: DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<JenisCat> JenisCat { get; set; }
        public DbSet<KondisiRumah> KondisiRumah { get; set; }
        public DbSet<Konsumen> Konsumen { get; set; }
    }
}