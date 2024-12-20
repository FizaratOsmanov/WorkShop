using Microsoft.EntityFrameworkCore;
using WorkShopApp.Core.Entities.Base;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;

namespace WorkShopApp.Data.Repositories.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }
    DbSet<T> table => _context.Set<T>();

    public async Task<T> CreateAsync(T T)
    {
       await table.AddAsync(T);
       return T;
    }
    public void Delete(T T)
    {
        table.Remove(T);
    }
    public async Task<ICollection<T>> GetAllAsync()
    {
       return await table.ToListAsync();            
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var result = await table.FirstOrDefaultAsync(x => x.Id == id);
        return result;
    }

    public void Update(T T)
    {
        table.Update(T);
    }
}
