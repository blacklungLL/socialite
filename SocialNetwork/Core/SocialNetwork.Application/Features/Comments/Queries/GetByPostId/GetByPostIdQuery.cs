using MediatR;

namespace SocialNetwork.Application.Features.Comments.Queries.GetByPostId
{
    public record GetByPostIdQuery(int PostId) : IRequest<IEnumerable<GetByPostIdDto>>;
}