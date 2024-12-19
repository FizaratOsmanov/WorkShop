using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopApp.Core.Entities;

namespace WorkShopApp.Data.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<WorkShop> WorkShops { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
