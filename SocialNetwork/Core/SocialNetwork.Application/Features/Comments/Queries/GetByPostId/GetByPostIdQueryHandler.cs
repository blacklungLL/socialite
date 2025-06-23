using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;

namespace SocialNetwork.Application.Features.Comments.Queries.GetByPostId
{
    internal class GetByPostIdQueryHandler : IRequestHandler<GetByPostIdQuery, IEnumerable<GetByPostIdDto>>
    {
        private readonly ICommentRepository _commentRepository;

        public GetByPostIdQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<IEnumerable<GetByPostIdDto>> Handle(GetByPostIdQuery query, CancellationToken cancellationToken)
        {
            if (query.PostId == 0)
            {
                return new List<GetByPostIdDto>();
            }

            var comments = await _commentRepository.GetByPostIdAsync(query.PostId);

            var result = comments.Select(comment => new GetByPostIdDto
            {
                Id = comment.Id,
                UserId = comment.UserId,
                PostId = comment.PostId,
                Content = comment.Content,
                Avatar = comment.Avatar
            });

            return result ?? new List<GetByPostIdDto>();
        }
    }
}