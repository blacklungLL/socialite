using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class Post : BaseAuditableEntity
{
    /// <summary>
    /// У кого из пользователей оставлен пост
    /// </summary>
    public int UserPageId { get; set; }
    
    /// <summary>
    /// Сам контент поста
    /// </summary>
    public string Content { get; set; }
    
    /// <summary>
    /// Количество лайков
    /// </summary>
    public int LikeCount { get; set; }
    
    /// <summary>
    /// Количество дизов
    /// </summary>
    public int DislikeCount { get; set; }
}