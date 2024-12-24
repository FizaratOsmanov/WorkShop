using WorkShopApp.BL.DTOs.WorkShopDTOs;
using WorkShopApp.BL.Services.Abstractions;
using WorkShopApp.Core.Entities;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;

namespace WorkShopApp.BL.Services.Implementations;

public class WorkShopService : IWorkShopService
{
    private readonly IWorkShopRepository _workShopRepository;
    private readonly AppDbContext _appDbContext;
    public WorkShopService(IWorkShopRepository workShopRepository, AppDbContext appDbContext)
    {
        _workShopRepository = workShopRepository;
        _appDbContext = appDbContext;
    }

    public async Task<WorkShop> CreateWorkShopAsync(CreateWorkShopDTO dto)
    {
        WorkShop workShop = new WorkShop
        {
            Title = dto.Title,
            Description = dto.Description,
            Location = dto.Location,
            IsDeleted=true

        };
        return await _workShopRepository.CreateAsync(workShop);

    }

    public async Task DeleteAsync(WorkShop workShop)
    {
        workShop.IsDeleted = true;
        workShop.DeletedAt = DateTime.UtcNow.AddHours(4);
        _workShopRepository.Update(workShop);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<ICollection<WorkShop>> GetAllAsync()
    {

        return await _workShopRepository.GetAllAsync();
    }

    public async Task<WorkShop> GetByIdAsync(int id)
    {
        WorkShop result = await _workShopRepository.GetByIdAsync(id);
        return result;
    }

}
