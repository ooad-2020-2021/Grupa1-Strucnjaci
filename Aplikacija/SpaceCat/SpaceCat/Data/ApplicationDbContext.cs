using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpaceCat;

namespace SpaceCat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SpaceCat.Anketa> Anketa { get; set; }
        public DbSet<SpaceCat.Opcija> Opcija { get; set; }
        public DbSet<SpaceCat.Destinacija> Destinacija { get; set; }
        public DbSet<SpaceCat.Faq> Faq { get; set; }
        public DbSet<SpaceCat.Komentar> Komentar { get; set; }
        public DbSet<SpaceCat.Macka> Macka { get; set; }
        public DbSet<SpaceCat.Novost> Novost { get; set; }
        public DbSet<SpaceCat.Putovanje> Putovanje { get; set; }
        public DbSet<SpaceCat.SlikaNovosti> SlikaNovosti { get; set; }
        public DbSet<SpaceCat.Utisak> Utisak { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anketa>().ToTable("Anketa");
            modelBuilder.Entity<Opcija>().ToTable("Opcija");
            modelBuilder.Entity<Destinacija>().ToTable("Destinacija");
            modelBuilder.Entity<Faq>().ToTable("Faq");
            modelBuilder.Entity<Komentar>().ToTable("Komentar");
            modelBuilder.Entity<Macka>().ToTable("Macka");
            modelBuilder.Entity<Novost>().ToTable("Novost");
            modelBuilder.Entity<Putovanje>().ToTable("Putovanje");
            modelBuilder.Entity<SlikaNovosti>().ToTable("SlikaNovosti");
            modelBuilder.Entity<Utisak>().ToTable("Utisak");
        }
    }
}