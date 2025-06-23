namespace SocialNetwork.Application.Features.Comments.Queries.GetByPostId;

public class GetByPostIdDto
{
    public int Id { get; set; }
    
    /// <summary>
    /// Какой пользователь оставил комментарий
    /// </summary>
    public int UserId { get; set; }
    
    /// <summary>
    /// Под каким постом оставлен комментарий
    /// </summary>
    public int PostId { get; set; }
    
    /// <summary>
    /// Содержимое комментария
    /// </summary>
    public string Content { get; set; }
    
    /// <summary>
    /// Аватар пользователя, который оставил комментарий
    /// </summary>
    public string Avatar { get; set; }
}