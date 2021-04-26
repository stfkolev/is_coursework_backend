using Microsoft.EntityFrameworkCore;
using RentACarBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RentACarBackend
{
    public class RentACarDbContext : DbContext
    {
        public RentACarDbContext(DbContextOptions<RentACarDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Filename=./rent_a_car.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Company>().ToTable("companies"); 
    }
}
