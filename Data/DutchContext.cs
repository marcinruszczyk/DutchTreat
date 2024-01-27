using DutchArt.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchArt.Data
{
    public class DutchContext : DbContext
    {
        

        public DutchContext(DbContextOptions<DutchContext> options): base(options)
        {
          
        }

        public DbSet<Product> Products { get; set; } 
        public DbSet<Order> Orders { get; set; }

        //protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer(_config["ConnectionStrings:DutchContextDb"]);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
               .HasData(new Order()
               { 
                   Id = 1,
                   OrderDate = DateTime.UtcNow,
                   OrderNumber = "12345"
               });
        }
    }
}
