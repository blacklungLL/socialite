using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Application.Interfaces.Repositories;

public interface IEventRepository
{
    Task<IEnumerable<Event>> GetByEventIdAsync(int eventId);
    Task<IEnumerable<Event>> GetAllEventsAsync();
}