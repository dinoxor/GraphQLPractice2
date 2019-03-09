using CarvedRock.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api
{
    public class CarvedRockContext : DbContext
    {
        public CarvedRockContext(DbContextOptions<CarvedRockContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {

        }
    }

}
