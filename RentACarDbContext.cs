using Microsoft.EntityFrameworkCore;
using RentACarBackend.Models.Cars;
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
        public DbSet<Country> Countries { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies().UseSqlite(@"Filename=./rent_a_car.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Company>().ToTable("companies"); 
        public DbSet<CarType> CarType { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Fuel> Fuel { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Color> Color { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Powertrain> Powertrain { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Transmission> Transmission { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Engine> Engine { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Model> Model { get; set; }
        public DbSet<RentACarBackend.Models.Cars.Car> Car { get; set; }
        public DbSet<RentACarBackend.Models.Rent> Rent { get; set; }
    }
}
