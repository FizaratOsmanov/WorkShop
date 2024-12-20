using Microsoft.EntityFrameworkCore;
using WorkShopApp.Core.Entities;

namespace WorkShopApp.Data.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<WorkShop> WorkShops { get; set; }
        public DbSet<Participant> Participants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
