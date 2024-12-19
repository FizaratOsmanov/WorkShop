using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopApp.Core.Entities.Base;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;

namespace WorkShopApp.Data.Repositories.Implementations
{
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
            throw new NotImplementedException();
        }

        public void Update(T T)
        {
            throw new NotImplementedException();
        }
    }
}
