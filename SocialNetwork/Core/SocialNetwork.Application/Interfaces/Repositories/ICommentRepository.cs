using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Application.Interfaces.Repositories;

public interface ICommentRepository
{
    Task<IEnumerable<Comment>> GetByPostIdAsync(int postId);
    Task<IEnumerable<Comment>> GetAllCommentsAsync();
}