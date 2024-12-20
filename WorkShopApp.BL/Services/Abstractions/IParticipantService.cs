using WorkShopApp.Core.Entities;

namespace WorkShopApp.BL.Services.Abstractions;

public interface IParticipantService
{
    Task<ICollection<Participant>> GetAllParticipantAsync();

    Task<Participant> GetParticipantByIdAsync(int id);

    Task<Participant> CreateWorkShopAsync(Participant participant);

    void Update(Participant participant);

    void Delete(Participant participant);
}
