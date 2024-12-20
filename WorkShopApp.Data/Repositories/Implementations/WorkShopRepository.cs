using WorkShopApp.Core.Entities;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;

namespace WorkShopApp.Data.Repositories.Implementations;

public class WorkShopRepository : GenericRepository<WorkShop>, IWorkShopRepository
{
    public WorkShopRepository(AppDbContext context) : base(context) { }   
}
