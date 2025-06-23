using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Application.Interfaces.Repositories;

public interface IPostRepository
{
    Task<IEnumerable<Post>> GetByUserPageIdAsync(int userPageId);
    Task<IEnumerable<Post>> GetAllPostsAsync();
}