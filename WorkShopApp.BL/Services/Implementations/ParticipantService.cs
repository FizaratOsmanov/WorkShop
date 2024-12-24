using WorkShopApp.BL.DTOs.ParticipantDTOs;
using WorkShopApp.BL.Services.Abstractions;
using WorkShopApp.Core.Entities;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;
using WorkShopApp.Data.Repositories.Implementations;

namespace WorkShopApp.BL.Services.Implementations;

public class ParticipantService : IParticipantService
{
    private readonly IParticipantRepository _participantRepository;
    private readonly AppDbContext _appDbContext;
    public ParticipantService(IParticipantRepository participantRepository, AppDbContext appDbContext)
    {
        _participantRepository = participantRepository;
        _appDbContext = appDbContext;
    }
    public async Task<Participant> CreateParticipantAsync(CreateParticipantDTO dto)
    {
        Participant part = new Participant
        {
            Name = dto.Name,
            Email = dto.Email,
            Phone = dto.Phone,
        };
        return await _participantRepository.CreateAsync(part);
    }

    public void Delete(Participant participant)
    {
        participant.IsDeleted = true;
        participant.DeletedAt = DateTime.UtcNow.AddHours(4);
        _participantRepository.Update(participant);
        _appDbContext.SaveChangesAsync();
    }

    public async Task<ICollection<Participant>> GetAllParticipantAsync()
    {
        return await _participantRepository.GetAllAsync();
    }




    public async Task<Participant> GetParticipantByIdAsync(int id)
    {
        return await _participantRepository.GetByIdAsync(id);
    }

    public void Update(Participant participant)
    {
        throw new NotImplementedException();
    }
}
