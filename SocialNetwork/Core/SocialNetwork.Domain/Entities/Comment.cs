using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class Comment : BaseAuditableEntity
{
    public int UserId { get; set; }
    public int PostId { get; set; }
    public string Content { get; set; }
    public string Avatar { get; set; }
}