using Microsoft.EntityFrameworkCore;
using turkeytime.Models;

namespace turkeytime.Data {

public class ApplicationDbContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set;}
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
