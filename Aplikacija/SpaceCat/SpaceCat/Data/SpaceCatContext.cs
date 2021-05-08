using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaceCat;

namespace SpaceCat.Data
{
    public class SpaceCatContext : DbContext
    {
        public SpaceCatContext (DbContextOptions<SpaceCatContext> options)
            : base(options)
        {
        }

        public DbSet<SpaceCat.Anketa> Anketa { get; set; }

        public DbSet<SpaceCat.Destinacija> Destinacija { get; set; }
    }
}
