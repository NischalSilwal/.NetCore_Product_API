using DatabasePractice1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace DatabasePractice1.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ImageDetail> Images { get; set; }

    }

}



