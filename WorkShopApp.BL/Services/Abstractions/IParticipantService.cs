using WorkShopApp.BL.DTOs.ParticipantDTOs;
using WorkShopApp.Core.Entities;

namespace WorkShopApp.BL.Services.Abstractions;

public interface IParticipantService
{
    Task<ICollection<Participant>> GetAllParticipantAsync();

    Task<Participant> GetParticipantByIdAsync(int id);

    Task<Participant> CreateParticipantAsync(CreateParticipantDTO dto);

    void Update(Participant participant);

    void Delete(Participant participant);
}
