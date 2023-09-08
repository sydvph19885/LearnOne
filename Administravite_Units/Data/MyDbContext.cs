using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Districs> Districts { get; set; }
        public DbSet<Wards> Wards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provinces>(pr =>
            {
                pr.HasKey(key => key.ID);
                pr.Property(p => p.Provinces_Name).IsRequired().HasMaxLength(255);
            });
            modelBuilder.Entity<Districs>(dt =>
            {
                dt.HasKey(key => key.ID);
                dt.Property(na => na.Districs_Name).HasMaxLength(255);
                dt.HasOne(e => e.Provinces)
                .WithMany(e => e.Districs)
                .HasForeignKey(e => e.Provinces_ID).IsRequired(false);
            });
            modelBuilder.Entity<Wards>(entity =>
            {
                entity.HasKey(s => s.ID);
                entity.Property(na => na.Wards_Name).HasMaxLength(255);
                entity.HasOne(e => e.Districs)
                .WithMany(e => e.Wards)
                .HasForeignKey(e => e.Districs_ID).IsRequired(false);
            });
        }
    }
}
