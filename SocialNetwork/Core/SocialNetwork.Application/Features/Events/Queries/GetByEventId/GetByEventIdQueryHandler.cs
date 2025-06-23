using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;

namespace SocialNetwork.Application.Features.Events.Queries.GetByEventId
{
    internal class GetByEventIdQueryHandler : IRequestHandler<GetByEventIdQuery, IEnumerable<GetByEventIdDto>>
    {
        private readonly IEventRepository _eventRepository;

        public GetByEventIdQueryHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<IEnumerable<GetByEventIdDto>> Handle(GetByEventIdQuery query, CancellationToken cancellationToken)
        {
            if (query.EventId == 0)
            {
                var allEvents = await _eventRepository.GetAllEventsAsync();
                return allEvents.Select(@event => new GetByEventIdDto()
                {
                    Id = @event.Id,
                    EventName = @event.EventName,
                    Image = @event.Image,
                    Author = @event.Author,
                    EventDate = @event.EventDate,
                    InterestedCnt = @event.InterestedCnt,
                    GoingCnt = @event.GoingCnt
                }).ToList();
            }

            // Получаем данные о мероприятии из репозитория
            var events = await _eventRepository.GetByEventIdAsync(query.EventId);

            // Преобразуем данные в DTO
            var result = events.Select(@event => new GetByEventIdDto
            {
                Id = @event.Id,
                EventName = @event.EventName,
                Image = @event.Image,
                Author = @event.Author,
                EventDate = @event.EventDate,
                InterestedCnt = @event.InterestedCnt,
                GoingCnt = @event.GoingCnt
            });

            return result ?? new List<GetByEventIdDto>();
        }
    }
}