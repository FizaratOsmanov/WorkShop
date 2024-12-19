using WorkShopApp.Core.Entities.Base;

namespace WorkShopApp.Data.Repositories.Abstractions;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<ICollection<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);

    Task<T> CreateAsync(T T);

    void Update(T T);

    void Delete(T T);

}
