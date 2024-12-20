using WorkShopApp.BL.DTOs.WorkShopDTOs;
using WorkShopApp.Core.Entities;

namespace WorkShopApp.BL.Services.Abstractions;

public interface IWorkShopService
{
    Task<WorkShop> CreateWorkShopAsync(CreateWorkShopDTO dto);
    Task DeleteAsync(WorkShop workShop);
    Task<ICollection<WorkShop>> GetAllAsync();
    Task<WorkShop> GetByIdAsync(int id);
}