using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;

namespace SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId
{
    internal class GetByUserPageIdQueryHandler : IRequestHandler<GetByUserPageIdQuery, IEnumerable<GetByUserPageIdDto>>
    {
        private readonly IPostRepository _postRepository;

        public GetByUserPageIdQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<GetByUserPageIdDto>> Handle(GetByUserPageIdQuery query, CancellationToken cancellationToken)
        {
            if (query.UserPageId == 0)
            {
                var allPosts = await _postRepository.GetAllPostsAsync();
                return allPosts.Select(post => new GetByUserPageIdDto
                {
                    Id = post.Id,
                    UserPageId = post.UserPageId,
                    Content = post.Content,
                    DislikeCount = post.DislikeCount,
                    LikeCount = post.LikeCount
                }).ToList();
            }
            
            var data = await _postRepository.GetByUserPageIdAsync(query.UserPageId);

            var result = data.Select(p => new GetByUserPageIdDto
            {
                Id = p.Id,
                UserPageId = p.UserPageId,
                Content = p.Content,
                DislikeCount = p.DislikeCount,
                LikeCount = p.LikeCount
            });

            return result ?? new List<GetByUserPageIdDto>(){ };
        }
    }
}
