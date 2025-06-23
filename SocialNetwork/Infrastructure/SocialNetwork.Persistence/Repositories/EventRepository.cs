using Microsoft.EntityFrameworkCore;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Persistence.Contexts;

namespace SocialNetwork.Persistence.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _repository;

        public EventRepository(ApplicationDbContext repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Event>> GetByEventIdAsync(int eventId)
        {
            return await _repository.Events
                .Where(e => e.Id == eventId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await _repository.Events.ToListAsync();
        }
    }
}