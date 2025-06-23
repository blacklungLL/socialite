using MediatR;

namespace SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId
{
    public record GetByUserPageIdQuery(int UserPageId) : IRequest<IEnumerable<GetByUserPageIdDto>>;
}