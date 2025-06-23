using SocialNetwork.Application.Features.Comments.Queries.GetByPostId;
using SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId;

namespace SocialNetwork.MVC.Models.Home
{
    public class HomeVM
    {
        public IEnumerable<GetByUserPageIdDto> Feeds { get; set; }
        public Dictionary<int, IEnumerable<GetByPostIdDto>> CommentsByPostId { get; set; }
    }
}