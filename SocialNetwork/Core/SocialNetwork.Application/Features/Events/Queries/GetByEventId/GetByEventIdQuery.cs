using MediatR;

namespace SocialNetwork.Application.Features.Events.Queries.GetByEventId
{
    public record GetByEventIdQuery(int EventId) : IRequest<IEnumerable<GetByEventIdDto>>;
}