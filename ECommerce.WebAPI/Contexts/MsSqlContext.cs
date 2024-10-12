using ECommerce.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebAPI.Contexts
{
    public class MsSqlContext:DbContext
    {
        public MsSqlContext(DbContextOptions opt) : base(opt) { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Ecommerce_db;User=sa;Password=admin12345678 ;TrustServerCertificate=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
