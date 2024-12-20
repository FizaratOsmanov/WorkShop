using WorkShopApp.BL.Services.Abstractions;
using WorkShopApp.Core.Entities;
using WorkShopApp.Data.DAL;

namespace WorkShopApp.BL.Services.Implementations;

public class ParticipantService : IParticipantService
{
    private readonly IParticipantService _participantService;
    private readonly AppDbContext _appDbContext;
    public ParticipantService(IParticipantService participantService, AppDbContext appDbContext)
    {
        _participantService = participantService;
        _appDbContext = appDbContext;
    }
    public Task<Participant> CreateWorkShopAsync(Participant participant)
    {
        throw new NotImplementedException();
    }

    public void Delete(Participant participant)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Participant>> GetAllParticipantAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Participant> GetParticipantByIdAsync(int id)
    {
        return await _participantService.GetParticipantByIdAsync(id);
    }

    public void Update(Participant participant)
    {
        throw new NotImplementedException();
    }
}
