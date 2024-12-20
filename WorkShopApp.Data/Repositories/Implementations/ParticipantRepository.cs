using WorkShopApp.Core.Entities;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;

namespace WorkShopApp.Data.Repositories.Implementations;

public class ParticipantRepository : GenericRepository<Participant>, IParticipantRepository
{
    public ParticipantRepository(AppDbContext context) : base(context) { }
   
}
