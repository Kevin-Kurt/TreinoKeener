using Microsoft.EntityFrameworkCore;
using Back_Estoque.Models;

namespace Backend_Estoque.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
              .Property(p => p.Name)
                .HasMaxLength(80);

            modelBuilder.Entity<Product>()
              .Property(p => p.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<User>()
                .HasData(
                    new User { UserId = 14535, Name = "jean", Password = "kevinkurt", ConfirmPassword = "kevinkurt" },
                    new User { UserId = 223435, Name = "gustavo", Password = "kevinkurt", ConfirmPassword = "kevinkurt" },
                    new User { UserId = 363634, Name = "marcelo", Password = "kevinkurt", ConfirmPassword = "kevinkurt" }
                );
        }

    }
}