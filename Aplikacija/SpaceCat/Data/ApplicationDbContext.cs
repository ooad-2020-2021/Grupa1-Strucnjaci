using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SpaceCat;

namespace SpaceCat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SpaceCat.Faq> Faq { get; set; }
        public DbSet<SpaceCat.Anketa> Anketa { get; set; }
        public DbSet<SpaceCat.Destinacija> Destinacija { get; set; }
        public DbSet<SpaceCat.Komentar> Komentar { get; set; }
        public DbSet<SpaceCat.Macka> Macka { get; set; }
        public DbSet<SpaceCat.Novost> Novost { get; set; }
        public DbSet<SpaceCat.Opcija> Opcija { get; set; }
        public DbSet<SpaceCat.Utisak> Utisak { get; set; }
        public DbSet<SpaceCat.Putovanje> Putovanje { get; set; }
        public DbSet<SpaceCat.SlikaNovosti> SlikaNovosti { get; set; }
    }
}
