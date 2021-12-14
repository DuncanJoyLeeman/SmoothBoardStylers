using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SmoothboardStylers.Models;

namespace SmoothboardStylers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Voorraad>().HasKey(v => new { v.SurfboardId, v.FiliaalId });
        }


        public DbSet<Filiaal> Filialen{ get; set; }
        public DbSet<Voorraad> Voorraad { get; set; }
        public DbSet<Surfboard> Surfboard { get; set; }
        public DbSet<Materiaal> Materiaal { get; set; }
        public DbSet<Interesse> Interesse { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<SmoothboardStylers.Models.FAQ> FAQ { get; set; }
    }
}
