using WorkShopApp.Core.Entities.Base;

namespace WorkShopApp.Data.Repositories.Abstractions;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<ICollection<T>> GetAllAsync();

    Task<T> CreateAsync(T T);

    Task<T> GetByIdAsync(int id);

    void Delete(T T);

    void Update(T T);
}
